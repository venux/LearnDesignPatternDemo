using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternLib._2结构型._06享元模式
{
    /// <summary>
    /// 享元工厂(FlyweightFactoiy)角色：本角色负责创建和管理享元角色。
    /// 本角色必须保证享元对象可以被系统适当地共享。
    /// 当一个客户端对象请求一个享元对象的时候，享元工厂角色需要检查系统中是否已经有一个符合要求的享元对象，
    /// 如果已经有了，享元工厂角色就应当提供这个已有的享元对象；
    /// 如果系统中没有一个适当的享元对象的话，享元工厂角色就应当创建一个新的合适的享元对象。
    /// </summary>
    public class FlavorFactory
    {
        private Hashtable flavors = new Hashtable();

        public AOrder GetOrder(string flavor)
        {
            if (flavors.ContainsKey(flavor) == false)
                flavors.Add(flavor, new Flavor(flavor));

            return (AOrder)flavors[flavor];
        }

        public int GetTotalFlavorsCount()
        {
            return flavors.Count;
        }
    }
}
