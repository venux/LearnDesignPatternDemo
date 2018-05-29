using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternLib._3行为型._09访问者模式
{
    public class Node2:ANode
    {
        /// <summary>
        /// 具体节点（Node）角色：实现了抽象元素所规定的接受操作。 
        /// </summary>
        /// <param name="vistor"></param>
        public override void Accept(AVistor vistor)
        {
            vistor.VisitNode2(this);
        }

        public override void Print()
        {
            Console.WriteLine("节点2");
        }
    }
}
