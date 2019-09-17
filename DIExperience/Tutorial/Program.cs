using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;
using Unity.RegistrationByConvention;

namespace Tutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine(string.Concat(Enumerable.Repeat("=", 30)));
                Console.WriteLine("1 階段 1 傳統緊密耦合開發方式");
                Console.WriteLine("2 階段 2 將具體實作類別解耦合成為介面，但使用手動注入方式");
                Console.WriteLine("3 階段 3 使用 DI Container 容器，自動進行註冊與解析");
                Console.WriteLine("0 結束");
                Console.WriteLine(string.Concat(Enumerable.Repeat("=", 30)));
                Console.WriteLine("請選擇要執行的階段:");
                string choice = Console.ReadLine();
                if (choice == "0")
                {
                    exit = true;
                }
                else
                {
                    OrderInfo orderInfo = new OrderInfo()
                    {
                        CustomerName = "Vulcan Lee",
                        Email = "vulcan@my.com",
                        Price = 55000,
                        Produt = "iPhone 12",
                        CreditCard = "1233211234567"
                    };

                    Console.WriteLine();
                    Console.WriteLine("進行訂單處理中...");

                    switch (choice)
                    {
                        case "1":
                            #region Phase 1
                            // 傳統緊密耦合開發方式，因此，我們需要自己建立所需要執行個體，也就是要使用 
                            // new 運算子與指定要產生類別的物件名稱
                            // 這樣，將會造成緊密耦合的設計結果
                            Phase1.OrderManager orderManagerPH1 = new Phase1.OrderManager();
                            orderManagerPH1.Procss(orderInfo);
                            #endregion
                            break;

                        case "2":
                            #region Phase 2
                            // 在這個 Phase2 命名空間內，我們已經將各個具體類別，分別進行介面抽象化，
                            // 並且在 OrderManager 類別的建構式上，分別需要傳入所需介面的具體實作類別物件
                            // 因此，在這裡，我們將會在建立 OrderManager 物件的時候，
                            // 將所需要的相關具體實作物件，都傳入到該建構函式內
                            Phase2.OrderManager orderManagerPH2 = new Phase2.OrderManager(
                                new Phase2.Billing(),
                                new Phase2.CustomerProcessor(new Phase2.CustomerRepository(), new Phase2.ProductRepository()),
                                new Phase2.Notification()
                                );
                            orderManagerPH2.Procss(orderInfo);
                            #endregion
                            break;

                        case "3":
                            #region Phase 3
                            // 這裡將會展示如何利用 Unity DI Container 相依性注入容器，
                            // 透過自動掃描組件中的所有介面與類別
                            // 建立 DI Container 內需要用到的型別對應集合
                            // 最後，將會透過 DI Container，自動進行具體類別 OrderManager (該類別沒有實作介面，一樣可以進行解析)
                            // 的物件，並且自動幫我們注入所需要用到的具體實作類別物件
                            IUnityContainer container = new UnityContainer();
                            container.RegisterTypes(
                            AllClasses.FromLoadedAssemblies()
                                    .Where(x => x.Namespace.EndsWith("Phase3")),
                            WithMappings.FromAllInterfaces,
                            WithName.Default,
                            WithLifetime.ContainerControlled);

                            Phase3.OrderManager orderManagerPH3 = container.Resolve<Phase3.OrderManager>();
                            orderManagerPH3.Procss(orderInfo);
                            #endregion
                            break;

                        default:
                            break;
                    }
                }
            }
        }
    }
}
