using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternLib._1创建型._02工厂方法模式
{
    /// <summary>
    /// 计算方法抽象类
    /// </summary>
    public abstract class MathCalculateBase
    {
        /// <summary>
        /// 计算方法
        /// </summary>
        /// <returns></returns>
        public abstract double Calculate(double Num1,double Num2);
    }
}
