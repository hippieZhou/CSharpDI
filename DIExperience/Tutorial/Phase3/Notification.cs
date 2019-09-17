using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial.Phase3
{
    public interface INotification
    {
        void Send(OrderInfo orderInfo);
    }
    public class Notification : INotification
    {
        public void Send(OrderInfo orderInfo)
        {
            Console.WriteLine($"已經送出通知給 {orderInfo.Email}");
        }
    }
}
