using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternLib._2结构型._02桥接模式
{
    /// <summary>
    /// 具体实现化(Concrete Implementor)角色：这个角色给出实现化角色接口的具体实现。
    /// </summary>
    public class ConcreteImplementorA : Implementor
    {
        public override void Operation()
        {
            Console.WriteLine("具体实现化角色a！");
        }
    }
}
