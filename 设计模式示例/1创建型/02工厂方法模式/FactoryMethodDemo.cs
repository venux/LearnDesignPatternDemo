using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternLib._1创建型._02工厂方法模式
{
    /// <summary>
    /// 工厂方法模式
    /// 工厂方法模式之所以可以解决简单工厂的模式，是因为它的实现把具体产品的创建推迟到子类中，此时工厂类不再负责所有产品的创建，而只是给出具体工厂必须实现的接口，这样工厂方法模式就可以允许系统不修改工厂类逻辑的情况下来添加新产品，这样也就克服了简单工厂模式中缺点。
    /// 使用工厂方法实现的系统，如果系统需要添加新产品时，我们可以利用多态性来完成系统的扩展，对于抽象工厂类和具体工厂中的代码都不需要做任何改动。
    ///  </summary>
    public class FactoryMethodDemo
    {
        public static void FactoryMethodDemoTest()
        {
            FactoryMethodBase factory1 = new AddFactoryMethod();
            MathCalculateBase calculate1 = factory1.CalculateFactory();
            double result1 = calculate1.Calculate(20, 20);
            Console.WriteLine(result1);

            FactoryMethodBase factory2 = new MinusFactoryMethod();
            MathCalculateBase calculate2 = factory2.CalculateFactory();
            double result2 = calculate2.Calculate(20, 20);
            Console.WriteLine(result2);

            FactoryMethodBase factory3 = new MultiFactoryMethod();
            MathCalculateBase calculate3 = factory3.CalculateFactory();
            double result3 = calculate1.Calculate(20, 20);
            Console.WriteLine(result3);

            FactoryMethodBase factory4 = new DivideFactoryMethod();
            MathCalculateBase calculate4 = factory4.CalculateFactory();
            double result4 = calculate4.Calculate(20, 20);
            Console.WriteLine(result4);
        }
    }

    /// <summary>
    /// 工厂方法-抽象基类
    /// </summary>
    public abstract class FactoryMethodBase
    {
        public abstract MathCalculateBase CalculateFactory();
    }

    public class AddFactoryMethod : FactoryMethodBase
    {
        public override MathCalculateBase CalculateFactory()
        {
            return new AddMathCalculate();
        }
    }

    public class MinusFactoryMethod : FactoryMethodBase
    {
        public override MathCalculateBase CalculateFactory()
        {
            return new MinusMathCalculate();
        }
    }

    public class MultiFactoryMethod : FactoryMethodBase
    {
        public override MathCalculateBase CalculateFactory()
        {
            return new MultiMathCalculate();
        }
    }

    public class DivideFactoryMethod : FactoryMethodBase
    {
        public override MathCalculateBase CalculateFactory()
        {
            return new DivideMathCalculate();
        }
    }
}
