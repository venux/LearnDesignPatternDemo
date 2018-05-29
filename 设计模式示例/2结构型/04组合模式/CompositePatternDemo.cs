using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternLib._2结构型._04组合模式
{
    /// <summary>
    /// 组合模式
    /// 组合模式允许你将对象组合成树形结构来表现”部分-整体“的层次结构，使得客户以一致的方式处理单个对象以及对象的组合。
    /// 合模式实现的最关键的地方是——简单对象和复合对象必须实现相同的接口。这就是组合模式能够将组合对象和简单对象进行一致处理的原因。
    /// </summary>
    public class CompositePatternDemo
    {
        public static void CompositePatternDemoTest()
        {
            Console.WriteLine("----------------------透明式----------------------");
            #region 透明式

            AComponent1 simpleObj1 = new SimpleObject1("线");
            simpleObj1.Print();

            AComponent1 complexObj1 = new ComplexObject1("线集合");
            complexObj1.Print();
            complexObj1.Add(simpleObj1);
            complexObj1.GetChildred();
            complexObj1.Remove(simpleObj1);
            complexObj1.GetChildred();

            #endregion

            Console.WriteLine("----------------------安全式----------------------");
            #region 安全式

            AComponent2 simpleObj2 = new SimpleObject2("线");
            simpleObj2.Print();

            ComplexObject2 complexObj2 = new ComplexObject2("线集合");
            complexObj2.Print();
            complexObj2.Add(simpleObj1);
            complexObj2.GetChildred();
            complexObj2.Remove(simpleObj1);
            complexObj2.GetChildred();

            #endregion
        }
    }
}
