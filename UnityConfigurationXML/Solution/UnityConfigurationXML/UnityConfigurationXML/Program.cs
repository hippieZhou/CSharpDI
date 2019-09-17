using Microsoft.Practices.Unity.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;

namespace UnityConfigurationXML
{
    public interface IMessage
    {
        void Write(string message);
    }

    public class ConsoleMessage : IMessage
    {
        public void Write(string message)
        {
            Console.WriteLine($"ConsoleMessage 物件的 HashCode {this.GetHashCode()}");
        }
    }

    public class FileMessage : IMessage
    {
        public void Write(string message)
        {
            Console.WriteLine($"FileMessage 物件的 HashCode {this.GetHashCode()}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // 這裡將會建立 DI 容器並且讀取 XML 內容
            // 建立型別對應註冊的工作
            IUnityContainer container = new UnityContainer().LoadConfiguration();

            // 進行抽象型別的具體實作物件的解析
            IMessage message = container.Resolve<IMessage>();

            // 執行取得物件的方法
            message.Write("Vulcan");

            Console.WriteLine("Press any key for continuing...");
            Console.ReadKey();
        }
    }
}
