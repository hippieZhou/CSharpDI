using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;
using Unity.Attributes;

namespace UnityDI
{
    public interface IEmployee
    {
        void DisplaySalary();
    }

    public class Employee : IEmployee
    {
        // 這個成員，需要透過 DI Container 的屬性注入方法，取得具體實作物件
        [Dependency]
        public ICompany PropertyInjectionCompany { get; set; }

        // 這個成員，需要透過 DI Container 的建構式注入方法，取得具體實作物件
        public ICompany ConstructorInjectionCompany { get; set; }

        // 這個成員，需要透過 DI Container 的方法注入方法，取得具體實作物件
        public ICompany MethodInjectionCompany { get; set; }

        [InjectionConstructor]
        public Employee(ICompany tmpCompany)
        {
            ConstructorInjectionCompany = tmpCompany;
        }

        // 這裡指定兩個方法，在建構式執行的時候(建立該類別的物件)，將會要自動執行
        [InjectionMethod]
        public void Initialize(ICompany tmpCompany)
        {
            MethodInjectionCompany = tmpCompany;
        }

        [InjectionMethod]
        public void AontherInitialize()
        {
            Console.WriteLine("執行其他方法進行初始化"); ;
        }
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
            // 這裡將會建立 DI 容器
            IUnityContainer unitycontainer = new UnityContainer();

            // 進行抽象型別與具體實作類別的註冊
            unitycontainer.RegisterType<ICompany, Company>();
            unitycontainer.RegisterType<IEmployee, Employee>();

            // 進行抽象型別的具體實作物件的解析
            IEmployee emp = unitycontainer.Resolve<IEmployee>();

            // 執行取得物件的方法
            emp.DisplaySalary();
            
            Console.WriteLine("Press any key for continuing...");
            Console.ReadKey();
        }
    }
}
