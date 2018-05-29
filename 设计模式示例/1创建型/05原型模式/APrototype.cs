using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternLib._1创建型._05原型模式
{
    /// <summary>
    /// 原型模式的抽象接口原型
    /// </summary>
    public abstract class APrototype
    {
        private string str = "";

        public string Str
        {
            get
            {
                return this.str;
            }
        }

        public APrototype(string str)
        {
            this.str = str;
        }

        public abstract APrototype Clone();
    }
}
