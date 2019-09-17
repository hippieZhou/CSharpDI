using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial.Phase3
{
    public interface ILogger
    {
        void Log(string message);
    }
    public class Logger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine($"寫入日誌中 : {message}");
        }
    }
}
