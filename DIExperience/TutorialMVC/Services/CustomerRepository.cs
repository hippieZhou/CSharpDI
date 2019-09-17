using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TutorialMVC.Services
{
    public interface ICustomerRepository
    {
        void Save();
    }
    public class CustomerRepository : ICustomerRepository
    {
        // ***********
        //若要在這個類別中加入寫入日誌功能，使用底下的建構式注入方法，並且解除 Save 方法內的註解
        private readonly ILogger _Logger;

        public CustomerRepository(ILogger logger)
        {
            _Logger = logger;
        }
        public void Save()
        {
            _Logger.Log("將會寫入到日誌檔案內");
            Console.WriteLine($"客戶紀錄已經更新");
        }
    }
}
