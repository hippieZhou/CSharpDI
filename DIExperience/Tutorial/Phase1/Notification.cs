using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial.Phase1
{
    public class Notification
    {
        public void Send(OrderInfo orderInfo)
        {
            Console.WriteLine($"已經送出通知給 {orderInfo.Email}");
        }
    }
}
