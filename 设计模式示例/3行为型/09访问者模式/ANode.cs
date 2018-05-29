using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternLib._3行为型._09访问者模式
{
    /// <summary>
    /// 抽象节点（Node）角色：声明一个接受操作，接受一个访问者对象作为一个参量。 
    /// </summary>
    public abstract class ANode
    {
        public abstract void Accept(AVistor vistor);

        public abstract void Print();
    }
}
