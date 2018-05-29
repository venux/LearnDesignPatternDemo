using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternLib._1创建型._02工厂方法模式
{
    public class SimpleFactoryDemo
    {
        /// <summary>
        /// 简单工厂设计模式测试
        /// </summary>
        public static void SimpleFactoryDemoTest()
        {
            SimpleFactory.SimpleFactoryDemoFunc(CalculateType.Add);
            SimpleFactory.SimpleFactoryDemoFunc(CalculateType.Minus);
            SimpleFactory.SimpleFactoryDemoFunc(CalculateType.Multi);
            SimpleFactory.SimpleFactoryDemoFunc(CalculateType.Divide);
        }
    }

    /// <summary>
    ///  简单工厂设计模式：不属于23种模式
    /// 缺点：
    /// •简单工厂类集中了所有创建逻辑，一旦不能正常工作，整个系统都会受到影响。
    /// •系统扩展困难，一旦添加新逻辑就不得不修改工厂方法逻辑，这样就会造成工厂逻辑过于复杂。
    /// 应用场景：
    /// •当工厂类负责创建的对象比较少时可以考虑使用简单工厂模式（）。
    /// •客户如果只知道传入工厂类的参数，对于如何创建对象的逻辑不关心时可以考虑使用简单工厂模式
    /// </summary>
    public class SimpleFactory
    {
        /// <summary>
        /// 简单工厂模式：将设计到的业务单独封装到一个类的静态方法中，从而实现业务操作和具体对象分离，解耦。
        /// </summary>
        public static void SimpleFactoryDemoFunc(CalculateType type, double Num1 = 20d, double Num2 = 20d)
        {
            try
            {
                MathCalculateBase mathCalculate = null;
                double result = 0.0d;

                switch (type)
                {
                    case CalculateType.Add:
                        mathCalculate = new AddMathCalculate();
                        break;
                    case CalculateType.Minus:
                        mathCalculate = new MinusMathCalculate();
                        break;
                    case CalculateType.Multi:
                        mathCalculate = new MultiMathCalculate();
                        break;
                    case CalculateType.Divide:
                        mathCalculate = new DivideMathCalculate();
                        break;
                    default:
                        break;
                }

                if (mathCalculate == null)
                    throw new Exception("请选择运算类型（加减乘除）！");

                result = mathCalculate.Calculate(Num1, Num2);

                Console.WriteLine(type.ToString() + "运算结果为：" + result);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
