using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;
using Unity.Attributes;
using Unity.Injection;
using Unity.Resolution;

namespace InjectingValueOverride
{
    public interface IMyInterface
    {

    }
    // 請設定預設將會注入這個具體實作類別
    public class DefaultClass : IMyInterface
    {

    }
    // 請練習當進行手動解析的時候，使用這個具體類別來覆蓋註冊時候的預設值
    public class NewClass : IMyInterface
    {

    }
    public interface IMessage
    {
        void Write(string message);
    }

    public class ConsoleMessage : IMessage
    {
        // 這個欄位值將會由建構式注入來設定
        public string Name { get; set; }
        // 這個欄位值將會由建構式注入來設定
        public int Age { get; set; }
        // 這個欄位值將會由建構式來注入來設定
        public IMyInterface _AnotherClass;
        // 這個欄位值將會由屬性注入方式來設定
        public double Cost { get; set; }
        // 這個欄位值將會由方法注入方式來設定
        public IMyInterface _MethodInjection;

        #region 建構式
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

        // 需要指定使用這個建構式來做為建構式注入的方法
        public ConsoleMessage(string name, int age,
            IMyInterface myInterface)
        {
            Name = name;
            Age = age;
            _AnotherClass = myInterface;
        }
        public ConsoleMessage(string name, int age, string name1, int age1)
        {
            Name = name;
            Age = age;
        }
        #endregion

        // 這個方法需要使用方法注入來呼叫
        public void Init(IMyInterface anotherInterface, string Msg)
        {
            _MethodInjection = anotherInterface;
            Console.WriteLine($"執行了方法注入:{Msg}");
        }
        public void Write(string message)
        {
            Console.WriteLine($"Name: {Name}  Age: {Age}");
            Console.WriteLine($"Cost: {Cost}");
            Console.WriteLine($"建構式注入 IAnotherInterface 具體實作類別為 {_AnotherClass.GetType().Name}");
            Console.WriteLine($"方法注入 IAnotherInterface 具體實作類別為 {_MethodInjection.GetType().Name}");
            Console.WriteLine($"訊息: {message} 已經寫入到螢幕上了");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
