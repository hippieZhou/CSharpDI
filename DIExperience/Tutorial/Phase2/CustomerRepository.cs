using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial.Phase2
{
    public interface ICustomerRepository
    {
        void Save();
    }
    public class CustomerRepository : ICustomerRepository
    {
        public void Save()
        {
            Console.WriteLine($"客戶紀錄已經更新");
        }
    }
}
