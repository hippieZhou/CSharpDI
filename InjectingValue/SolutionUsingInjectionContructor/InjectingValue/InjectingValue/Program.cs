using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;
using Unity.Attributes;
using Unity.Injection;

namespace InjectingValue
{
    public interface IAnotherInterface
    {

    }
    public class AnotherClass : IAnotherInterface
    {

    }
    public interface IMessage
    {
        void Write(string message);
    }

    public class ConsoleMessage : IMessage
    {
        public string Name { get; }
        public int Age { get; }
        [Dependency]
        public double Cost { get; set; }
        public IAnotherInterface _AnotherClass { get; set; }
        public ConsoleMessage()
        {
            Name = "???";
            Age = -99;
        }

        public ConsoleMessage(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public ConsoleMessage(string name, int age, 
            IAnotherInterface iAnotherInterface)
        {
            Name = name;
            Age = age;
            _AnotherClass = iAnotherInterface;
        }


        public void Write(string message)
        {
            Console.WriteLine($"Name: {Name}  Age: {Age}");
            Console.WriteLine($"Cost: {Cost}");
            Console.WriteLine($"IAnotherInterface 具體實作類別為 {_AnotherClass.GetType().Name}");
            Console.WriteLine($"訊息: {message} 已經寫入到螢幕上了");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // 這裡將會建立 DI 容器
            IUnityContainer container = new UnityContainer();

            // 進行抽象型別與具體實作類別的註冊
            container.RegisterType<IAnotherInterface, AnotherClass>();

            // 進行抽象型別的具體實作物件的解析
            // ConsoleMessage 類別內有三個建構式
            // 使用 InjectionConstructor 指定使用哪個建構式
            container.RegisterType<IMessage, ConsoleMessage>(
                new InjectionConstructor("Vulcan", 50, 
                typeof(IAnotherInterface)),
                new InjectionProperty("Cost", 999.168));

            // 進行抽象型別的具體實作物件的解析
            IMessage message = container.Resolve<IMessage>();

            // 執行取得物件的方法
            message.Write("Hi Vulcan");

            Console.WriteLine("Press any key for continuing...");
            Console.ReadKey();
        }
    }
}
