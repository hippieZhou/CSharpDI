using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TutorialMVC.Services
{
    public interface ICustomerProcessor
    {
        void UpdateCustomerOrder(OrderInfo orderInfo);
    }
    public class CustomerProcessor : ICustomerProcessor
    {
        readonly ICustomerRepository _CustomerRepository;
        readonly IProductRepository _ProductRepository;

        public CustomerProcessor(ICustomerRepository CustomerRepository, IProductRepository ProductRepository)
        {
            _CustomerRepository = CustomerRepository;
            _ProductRepository = ProductRepository;
        }

        public void UpdateCustomerOrder(OrderInfo orderInfo)
        {
            _CustomerRepository.Save();
            _ProductRepository.Save();

            Console.WriteLine($"已經更新 {orderInfo.CustomerName} 客戶 {orderInfo.Produt} 產品訂單資訊");
        }
    }
}
