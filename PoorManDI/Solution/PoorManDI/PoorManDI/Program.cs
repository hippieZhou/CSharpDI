using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoorManDI
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
        public void Write(string message)
        {
            Console.WriteLine($"訊息: {message} 已經寫入到檔案上了");
        }
    }

    public static class MyDI
    {
        // 這裡的資料字典，將會儲存抽象型別與具體實作型別集合的所有資料
        static readonly Dictionary<Type, Type> Maps = new Dictionary<Type, Type>();

        // 提供抽象與具體實作型別，儲存到型別對應的資料字典內
        public static void Register<TAbstractType, TConcreteType>()
        {
            // 為了練習方便，在這裡，我們不去檢查抽象型別是否存在與
            // 處理相關例外異常問題
            Maps[typeof(TAbstractType)] = typeof(TConcreteType);
        }

        // 透過提供抽象型別，可以解析出對應的具體實作型別
        public static TAbstractType Resolve<TAbstractType>()
        {
            // 透過抽象型別，取得該抽象型別的具體實作型別
            Type fooConcreteType = Maps[typeof(TAbstractType)];
            // 使用 反映 (Reflection) API，動態產生該型別物件
            Object instance = Activator.CreateInstance(fooConcreteType);
            return (TAbstractType)instance;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // 當要變更使用 ConsoleMessage 型別功能的時候，該如何因應呢？
            //MyDI.Register<IMessage, ConsoleMessage>();
            // 進行註冊抽象與具體實作型別
            MyDI.Register<IMessage, FileMessage>();

            SendMessage("Hi Poor DI");

            Console.WriteLine("Press any key for continuing...");
            Console.ReadKey();

        }

        private static void SendMessage(string message)
        {
            // 取得該抽象別別的具體實作物件，並且執行該物件的方法
            var fooIMessage = MyDI.Resolve<IMessage>();
            fooIMessage.Write(message);
        }
    }
}
