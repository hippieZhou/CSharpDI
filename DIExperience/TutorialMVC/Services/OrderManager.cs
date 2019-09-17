using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TutorialMVC.Services
{
    public interface IOrderManager
    {
        void Procss(OrderInfo orderInfo);
    }
    public class OrderManager : IOrderManager
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
            _Billing.ProcessPayment(orderInfo);
            _CustomerProcessor.UpdateCustomerOrder(orderInfo);
            _Notification.Send(orderInfo);
        }
    }
}
