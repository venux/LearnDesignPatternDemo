using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternLib._1创建型._05原型模式
{
    /// <summary>
    /// 原型抽象类的具体实现类
    /// </summary>
    public class ConcretePrototype:APrototype
    {
        public ConcretePrototype(string str) : base(str)
        {

        }

        /// <summary>
        /// 复习原型的Clone方法，实现浅拷贝
        /// </summary>
        /// <returns></returns>
        public override APrototype Clone()
        {
            return (APrototype)this.MemberwiseClone();
        }
    }
}
