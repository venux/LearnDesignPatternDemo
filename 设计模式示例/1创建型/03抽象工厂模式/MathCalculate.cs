using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternLib._1创建型._03抽象工厂模式
{
    /// <summary>
    /// 加运算
    /// </summary>
    public class AddMathCalculate : MathCalculateBase
    {
        public override double Calculate(double Num1, double Num2)
        {
            return Num1 + Num2;
        }
    }

    /// <summary>
    /// 减运算
    /// </summary>
    public class MinusMathCalculate : MathCalculateBase
    {
        public override double Calculate(double Num1, double Num2)
        {
            return Num1 - Num2;
        }
    }

    /// <summary>
    /// 乘运算
    /// </summary>
    public class MultiMathCalculate : MathCalculateBase
    {
        public override double Calculate(double Num1, double Num2)
        {
            return Num1 * Num2;
        }
    }

    /// <summary>
    /// 除运算
    /// </summary>
    public class DivideMathCalculate : MathCalculateBase
    {
        public override double Calculate(double Num1, double Num2)
        {
            if (Num2 == 0)
                throw new Exception("除数不能为0！");

            return Num1 / Num2;
        }
    }

    /// <summary>
    /// 运算类型
    /// </summary>
    public enum CalculateType
    {
        Add,
        Minus,
        Multi,
        Divide
    }
}
