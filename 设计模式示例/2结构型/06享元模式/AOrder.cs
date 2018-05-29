using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternLib._2结构型._06享元模式
{
    /// <summary>
    /// 抽象享元角色：此角色是所有的具体享元类的超类，为这些类规定出需要实现的公共接口。
    /// 那些需要外蕴状态(External State)的操作可以通过方法的参数传入。
    /// 抽象享元的接口使得享元变得可能，但是并不强制子类实行共享，因此并非所有的享元对象都是可以共享的。
    /// </summary>
    public abstract class AOrder
    {
        /// <summary>
        /// 卖咖啡给某座客人
        /// </summary>
        /// <param name="table"></param>
        public abstract void Serve(Table table);

        /// <summary>
        /// 获取咖啡名称
        /// </summary>
        /// <returns></returns>
        public abstract string GetCofferName();
    }
}
