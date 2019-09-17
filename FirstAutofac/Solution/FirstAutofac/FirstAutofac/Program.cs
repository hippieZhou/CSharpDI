using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstAutofac
{
    public interface IMessage
    {
        void Write(string message);
    }

    public class ConsoleMessage : IMessage
    {
        public void Write(string message)
        {
            Console.WriteLine($"訊息: {message} 已經寫入到螢幕上了");
        }
    }

    public class FileMessage : IMessage
    {
        ILog _Log;
        public FileMessage(ILog log)
        {
            _Log = log;
        }
        public void Write(string message)
        {
            Console.WriteLine($"訊息: {message} 已經寫入到檔案上了");
            _Log.Write(message);
        }
    }

    public interface ILog
    {
        void Write(string message);
    }

    public class Log : ILog
    {
        public void Write(string message)
        {
            Console.WriteLine($"訊息: {message} 已經寫入到 Log 上了");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // 準備建立型別對應註冊的工作
            var builder = new ContainerBuilder();
            // 進行抽象型別與具體實作類別的註冊
            builder.RegisterType<ConsoleMessage>().As<IMessage>();

            // 請嘗試確認深層注入的行為，是否可以正常運作
            //builder.RegisterType<FileMessage>().As<IMessage>();
            //builder.RegisterType<Log>().As<ILog>();

            // 這裡將會建立 DI 容器
            IContainer container = builder.Build();

            // 進行抽象型別的具體實作物件的解析
            IMessage message = container.Resolve<IMessage>();

            // 執行取得物件的方法
            message.Write("Hi Vulcan");

            Console.WriteLine("Press any key for continuing...");
            Console.ReadKey();
        }
    }
}
