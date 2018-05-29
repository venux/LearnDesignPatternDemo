using DesignPatternLib._1创建型._02工厂方法模式;
using DesignPatternLib._1创建型._03抽象工厂模式;
using DesignPatternLib._1创建型._04建造者模式;
using DesignPatternLib._1创建型._05原型模式;
using DesignPatternLib._2结构型._01适配器模式;
using DesignPatternLib._2结构型._02桥接模式;
using DesignPatternLib._2结构型._03装饰者模式;
using DesignPatternLib._2结构型._04组合模式;
using DesignPatternLib._2结构型._05外观模式;
using DesignPatternLib._2结构型._06享元模式;
using DesignPatternLib._2结构型._07代理模式;
using DesignPatternLib._2结构型._07代理模式.远程代理例子;
using DesignPatternLib._3行为型._01模板方法模式;
using DesignPatternLib._3行为型._03迭代器模式;
using DesignPatternLib._3行为型._04观察者模式;
using DesignPatternLib._3行为型._05中介者模式;
using DesignPatternLib._3行为型._06状态模式;
using DesignPatternLib._3行为型._07策略模式;
using DesignPatternLib._3行为型._08责任链模式;
using DesignPatternLib._3行为型._09访问者模式;
using DesignPatternLib._3行为型._10备忘录模式;
using DesignPatternLib._3行为型._11解释器模式;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternTest
{
    public class Program
    {
        static void Main(string[] args)
        {
            #region 创建型

            #region 工厂方法模式

            ////简单工厂模式（不在23种模式中）
            //SimpleFactoryDemo.SimpleFactoryDemoTest();
            //FactoryMethodDemo.FactoryMethodDemoTest();

            #endregion

            #region 抽象方法模式

            //AbstractFactoryDemo.AbstractFactoryDemoTest();

            #endregion

            #region 建造者模式

            //BuilderDemo.BuilderDemoTest();

            #endregion

            #region 原型模式

            //PrototypeDemo.PrototypeDemoTest();

            #endregion

            #endregion

            #region 结构型

            #region 适配器模式

            //AdapterDemo.AdapterDemoTest();

            #endregion

            #region 桥接模式

            //BridgeDemo.BridgeDemoTest();

            #endregion

            #region 装饰者模式

            //DecoratorDemo.DecoratorDemoTest();

            #endregion

            #region 组合模式

            //CompositePatternDemo.CompositePatternDemoTest();

            #endregion

            #region 门面角色

            //FacadePatternDemo.FacadePatternDemoTest();

            #endregion

            #region 享元模式

            //FlyweightDemo.FlyweightDemoTest();

            #endregion

            #region 代理模式

            //ProxyDemo.ProxyDemoTest();
            //MathProxyDemo.MathProxyDemoTest();

            #endregion

            #endregion

            #region 行为型

            #region 模板方法模式

            //TemplateMethodDemo.TemplateMethodDemoTest();

            #endregion

            #region 命令模式

            //DesignPatternLib._3行为型._02命令模式.CommandDemo.CommandDemoTest();

            #endregion

            #region 迭代器模式

            //IteratorDemo.IteratorDemoTest();

            #endregion

            #region 观察者模式

            //ObserverDemo.ObserverDemoTest();

            #endregion

            #region 中介者模式

            //MediatorDemo.MediatorDemoTest();

            #endregion

            #region 状态者模式

            //StateDemo.StateDemoTest();

            #endregion

            #region 策略模式

            //StrategyDemo.StrategyDemoTest();

            #endregion

            #region 责任链模式

            //ChainOfResponseDemo.ChainOfResponseDemoTest();

            #endregion

            #region 访问者模式

            //VisitorDemo.VisitorDemoTest();

            #endregion

            #region 备忘录模式

            //MemoDemo.MemoDemoTest();

            #endregion

            #region 解释器模式

            Calculator cal = new Calculator();
            cal.Test();

            #endregion

            #endregion

            Console.ReadLine();
        }
    }
}
