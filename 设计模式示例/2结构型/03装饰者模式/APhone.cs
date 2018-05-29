using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternLib._2结构型._03装饰者模式
{
    /// <summary>
    /// 抽象构件类-电话
    /// </summary>
    public abstract class APhone
    {
        /// <summary>
        /// 输出品牌
        /// </summary>
        public abstract void Print();
    }
}
