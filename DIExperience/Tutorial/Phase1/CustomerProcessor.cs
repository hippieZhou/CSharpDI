using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial.Phase1
{
    public class CustomerProcessor
    {
        public void UpdateCustomerOrder(OrderInfo orderInfo)
        {
            CustomerRepository customerRepository = new CustomerRepository();
            ProductRepository productRepository = new ProductRepository();

            customerRepository.Save();
            productRepository.Save();

            Console.WriteLine($"已經更新 {orderInfo.CustomerName} 客戶 {orderInfo.Produt} 產品訂單資訊");
        }
    }
}
