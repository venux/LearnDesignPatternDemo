using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternLib._2结构型._02桥接模式
{
    /// <summary>
    /// 抽象化(Abstraction)角色：抽象化给出的定义，并保存一个对实现化对象的引用。
    /// </summary>
    public class Abstraction
    {
        public Implementor Implementor
        {
            set;
            get;
        }

        public virtual void Operation()
        {
            Implementor.Operation();
        }
    }
}
