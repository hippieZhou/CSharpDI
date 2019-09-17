using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TutorialMVC.Controllers
{
    public class HomeController : Controller
    {
        public HomeController(Services.IOrderManager orderManager)
        {
            Services.OrderInfo orderInfo = new Services.OrderInfo()
            {
                CustomerName = "Vulcan Lee",
                Email = "vulcan@my.com",
                Price = 55000,
                Produt = "iPhone 12",
                CreditCard = "1233211234567"
            };
            orderManager.Procss(orderInfo);
        }
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}