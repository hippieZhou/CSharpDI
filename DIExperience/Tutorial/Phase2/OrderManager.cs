using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial.Phase2
{
    public class OrderManager 
    {
        readonly IBilling _Billing;
        readonly ICustomerProcessor _CustomerProcessor;
        readonly INotification _Notification;

        public OrderManager(IBilling billing, ICustomerProcessor customerProcessor, INotification notification)
        {
            _Billing = billing;
            _CustomerProcessor = customerProcessor;
            _Notification = notification;
        }

        public void Procss(OrderInfo orderInfo)
        {
            Console.WriteLine("Phase 2");
            _Billing.ProcessPayment(orderInfo);
            _CustomerProcessor.UpdateCustomerOrder(orderInfo);
            _Notification.Send(orderInfo);
        }
    }
}
