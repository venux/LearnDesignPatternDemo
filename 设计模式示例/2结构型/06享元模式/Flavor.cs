using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternLib._2结构型._06享元模式
{
    /// <summary>
    /// 具体享元(ConcreteFlyweight)角色：实现抽象享元角色所规定的接口。
    /// 如果有内蕴状态的话，必须负责为内蕴状态提供存储空间。
    /// 享元对象的内蕴状态必须与对象所处的周围环境无关，从而使得享元对象可以在系统内共享。
    /// 有时候具体享元角色又叫做单纯具体享元角色，因为复合享元角色是由单纯具体享元角色通过复合而成的。
    /// </summary>
    public class Flavor : AOrder
    {
        private string flavor;

        public Flavor(string flavor)
        {
            this.flavor = flavor;
        }

        public override string GetCofferName()
        {
            return flavor;
        }

        public override void Serve(Table table)
        {
            Console.WriteLine("客户桌号：{0}，咖啡口味：{1}。", table.TableNum, flavor);
        }
    }
}
