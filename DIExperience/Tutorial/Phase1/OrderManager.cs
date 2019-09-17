using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial.Phase1
{
    public class OrderManager
    {
        public void Procss(OrderInfo orderInfo)
        {
            Billing billing = new Billing();
            CustomerProcessor custmerProcessor = new CustomerProcessor();
            Notification notification = new Notification();

            Console.WriteLine("Phase 1 ");
            billing.ProcessPayment(orderInfo);
            custmerProcessor.UpdateCustomerOrder(orderInfo);
            notification.Send(orderInfo);
        }
    }
}
