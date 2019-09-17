using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;

namespace InjectingObject
{
    public interface IMessage
    {
        void Write(string message);
    }

    public class ConsoleMessage : IMessage
    {

        public void Write(string message)
        {
            Console.WriteLine($"此物件的 HashCode {this.GetHashCode()}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // 這裡將會建立 DI 容器
            IUnityContainer container = new UnityContainer();

            // 進行抽象型別與自行產生的物件的註冊
            IMessage message = new ConsoleMessage();
            container.RegisterInstance<IMessage>(message);

            // 進行抽象型別的具體實作物件的解析
            IMessage message1 = container.Resolve<IMessage>();
            IMessage message2 = container.Resolve<IMessage>();
            IMessage message3 = container.Resolve<IMessage>();

            // 執行取得物件的方法
            message1.Write("Hi Vulcan1");
            message2.Write("Hi Vulcan2");
            message3.Write("Hi Vulcan3");

            Console.WriteLine("Press any key for continuing...");
            Console.ReadKey();
        }
    }
}
