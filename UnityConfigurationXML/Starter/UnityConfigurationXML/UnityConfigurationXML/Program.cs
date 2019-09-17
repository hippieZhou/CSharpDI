using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        }
    }
}
