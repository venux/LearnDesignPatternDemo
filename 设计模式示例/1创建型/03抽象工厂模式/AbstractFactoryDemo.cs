using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternLib._1创建型._03抽象工厂模式
{
    /// <summary>
    /// 抽象工厂模式
    /// 工厂方法模式每个具体工厂类只完成单个实例的创建,所以它具有很好的可扩展性。但是在现实生活中，一个工厂只创建单个产品这样的例子很少，因为现在的工厂都多元化了，一个工厂创建一系列的产品，如果我们要设计这样的系统时，工厂方法模式显然在这里不适用，然后抽象工厂模式却可以很好地解决一系列产品创建的问题。
    /// 抽象工厂模式：提供一个创建产品的接口来负责创建相关或依赖的对象，而不具体明确指定具体类。抽象工厂允许客户使用抽象的接口来创建一组相关产品，而不需要知道或关心实际生产出的具体产品是什么。这样客户就可以从具体产品中被解耦。
    /// 抽象工厂模式将具体产品的创建延迟到具体工厂的子类中，这样将对象的创建封装起来，可以减少客户端与具体产品类之间的依赖，从而使系统耦合度低，这样更有利于后期的维护和扩展，这真是抽象工厂模式的优点所在，然后抽象模式同时也存在不足的地方。
    /// 缺点：抽象工厂模式很难支持新种类产品的变化。这是因为抽象工厂接口中已经确定了可以被创建的产品集合，如果需要添加新产品，此时就必须去修改抽象工厂的接口，这样就涉及到抽象工厂类的以及所有子类的改变，这样也就违背了“开发——封闭”原则。
    /// 应用：
    /// •一个系统不要求依赖产品类实例如何被创建、组合和表达的表达，这点也是所有工厂模式应用的前提。
    /// •这个系统有多个系列产品，而系统中只消费其中某一系列产品
    /// •系统要求提供一个产品类的库，所有产品以同样的接口出现，客户端不需要依赖具体实现。
    ///  </summary>
    public class AbstractFactoryDemo
    {
        public static void AbstractFactoryDemoTest()
        {
            AbstractFactoryBase factory1 = new AbstractFactorySon1();
            MathCalculateBase calculate1 = factory1.MathCalculate();
            double result1 = calculate1.Calculate(20, 20);
            Console.WriteLine(result1);
            ChineseSpellBase spell1 = factory1.ChineseSpell();
            spell1.Spell();

            AbstractFactoryBase factory2 = new AbstractFactorySon2();
            MathCalculateBase calculate2 = factory2.MathCalculate();
            double result2 = calculate2.Calculate(20, 20);
            Console.WriteLine(result2);
            ChineseSpellBase spell2 = factory2.ChineseSpell();
            spell2.Spell();

            AbstractFactoryBase factory3 = new AbstractFactorySon3();
            MathCalculateBase calculate3 = factory3.MathCalculate();
            double result3 = calculate1.Calculate(20, 20);
            Console.WriteLine(result3);
            ChineseSpellBase spell3 = factory3.ChineseSpell();
            spell3.Spell();

            AbstractFactoryBase factory4 = new AbstractFactorySon4();
            MathCalculateBase calculate4 = factory4.MathCalculate();
            double result4 = calculate4.Calculate(20, 20);
            Console.WriteLine(result4);
            ChineseSpellBase spell4 = factory4.ChineseSpell();
            spell4.Spell();
        }
    }

    /// <summary>
    /// 工厂方法-抽象基类
    /// </summary>
    public abstract class AbstractFactoryBase
    {
        public abstract MathCalculateBase MathCalculate();
        public abstract ChineseSpellBase ChineseSpell();
    }

    public class AbstractFactorySon1 : AbstractFactoryBase
    {
        public override MathCalculateBase MathCalculate()
        {
            return new AddMathCalculate();
        }

        public override ChineseSpellBase ChineseSpell()
        {
            return new TangShiChineseSpell();
        }
    }

    public class AbstractFactorySon2 : AbstractFactoryBase
    {
        public override MathCalculateBase MathCalculate()
        {
            return new MinusMathCalculate();
        }

        public override ChineseSpellBase ChineseSpell()
        {
            return new SongCiChineseSpell();
        }
    }

    public class AbstractFactorySon3 : AbstractFactoryBase
    {
        public override MathCalculateBase MathCalculate()
        {
            return new MultiMathCalculate();
        }

        public override ChineseSpellBase ChineseSpell()
        {
            return new YuanQuChineseSpell();
        }
    }

    public class AbstractFactorySon4 : AbstractFactoryBase
    {
        public override MathCalculateBase MathCalculate()
        {
            return new DivideMathCalculate();
        }

        public override ChineseSpellBase ChineseSpell()
        {
            return new MingXiaoShuoChineseSpell();
        }
    }
}
