using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternLib._3行为型._09访问者模式
{
    /// <summary>
    /// 具体访问者（ConcreteVisitor）角色：实现抽象访问者角色所声明的接口，也就是抽象访问者所声明的各个访问操作。
    /// </summary>
    public class Vistor1 : AVistor
    {
        public override void VisitNode1(ANode node1)
        {
            Console.WriteLine("访问者1");
            node1.Print();
        }

        public override void VisitNode2(ANode node2)
        {
            Console.WriteLine("访问者1");
            node2.Print();
        }

        public override void VisitNode3(ANode node3)
        {
            Console.WriteLine("访问者1");
            node3.Print();
        }
    }
}
