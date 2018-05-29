using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternLib._2结构型._06享元模式
{
    /// <summary>
    /// 客户端(Client)角色：本角色还需要自行存储所有享元对象的外蕴状态。
    /// </summary>
    public class Client
    {
        private static FlavorFactory flavorFactory;
        private static int orderCount = 0;

        public static void FlyweightTest()
        {
            flavorFactory = new FlavorFactory();

            TakeOrder("蓝山咖啡");
            TakeOrder("雀巢咖啡");
            TakeOrder("益昌老街咖啡");
            TakeOrder("立顿咖啡");
            TakeOrder("卡布奇诺咖啡");
            TakeOrder("蓝山咖啡");
            TakeOrder("益昌老街咖啡");

            Console.WriteLine("共卖出{0}杯咖啡,共{1}种咖啡！", orderCount, flavorFactory.GetTotalFlavorsCount());
        }
        
        private static void TakeOrder(string flavor)
        {
            AOrder order = flavorFactory.GetOrder(flavor);

            order.Serve(new Table(++orderCount));
        }
    }
}
