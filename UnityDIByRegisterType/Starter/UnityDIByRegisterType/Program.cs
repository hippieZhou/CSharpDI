using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnityDIByRegisterType
{
    public interface IEmployee
    {
        void DisplaySalary();
    }

    public class Employee : IEmployee
    {
        // 這個成員，需要透過 DI Container 的屬性注入方法，取得具體實作物件
        public ICompany PropertyInjectionCompany { get; set; }
        // 這個成員，需要透過 DI Container 的建構式注入方法，取得具體實作物件
        public ICompany ConstructorInjectionCompany { get; set; }
        // 這個成員，需要透過 DI Container 的方法注入方法，取得具體實作物件
        public ICompany MethodInjectionCompany { get; set; }

        public void DisplaySalary()
        {
            PropertyInjectionCompany.ShowSalary();
            ConstructorInjectionCompany.ShowSalary();
            MethodInjectionCompany.ShowSalary();

            Console.WriteLine($"Property Injection Object Hash Code is {PropertyInjectionCompany.GetHashCode()}");
            Console.WriteLine($"Constructor Injection Object Hash Code is {ConstructorInjectionCompany.GetHashCode()}");
            Console.WriteLine($"Method Injection Object Hash Code is {MethodInjectionCompany.GetHashCode()}");
        }
    }

    public interface ICompany
    {
        void ShowSalary();
    }

    public class Company : ICompany
    {
        public Company()
        {
            Console.WriteLine($"Company Object Hash Code = {this.GetHashCode()}");
        }
        public void ShowSalary()
        {
            Console.WriteLine("你的薪水是 22 K");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
