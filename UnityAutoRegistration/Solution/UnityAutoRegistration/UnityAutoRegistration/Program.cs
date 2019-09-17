using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;
using Unity.Attributes;
using Unity.RegistrationByConvention;

namespace UnityAutoRegistration
{
    public interface IMyMessage
    {
        void Write(string message);
    }

    public class ConsoleMessage : IMyMessage
    {
        public ConsoleMessage()
        {

        }
        public void Write(string message)
        {
            Console.WriteLine($"此物件的 HashCode {this.GetHashCode()}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // 自動掃描所指定的組件內容，根據不同引數設定，自動掃描組件內的所有型別，
            // 進而判斷與加入抽象介面型別與具體實作類別的對應關係，並且使用預設的注入物件生命週期
            IUnityContainer container = new UnityContainer();
            container.RegisterTypes(
                AllClasses.FromLoadedAssemblies().Where(x=>x.Namespace.Contains("UnityAutoRegistration")),
                WithMappings.FromAllInterfaces,
                WithName.Default,
                WithLifetime.ContainerControlled);

            // 進行抽象型別的具體實作物件的解析
            IMyMessage message = container.Resolve<IMyMessage>();

            // 執行取得物件的方法
            message.Write("Vulcan");

            Console.WriteLine();
            Console.WriteLine("顯示 IoC 容器中的所有型別對應");
            // 使用 IUnityContainer.Registrations 屬性值，
            // 來查看究竟有那些抽象型別與具體實作類別對應關係，加入到 DI Container 內呢？
            foreach (var item in container.Registrations)
            {
                if (item.MappedToType.Name == item.RegisteredType.Name) continue;
                Console.WriteLine($"Name : {item.Name}");
                Console.WriteLine($"RegisteredType : {item.RegisteredType.Name}");
                Console.WriteLine($"MappedToType : {item.MappedToType.Name}");
                Console.WriteLine($"LifetimeManager : {item.LifetimeManager.LifetimeType.Name}");
                Console.WriteLine();
            }

            Console.WriteLine("Press any key for continuing...");
            Console.ReadKey();
        }
    }
}
