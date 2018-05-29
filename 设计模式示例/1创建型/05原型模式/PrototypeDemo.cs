using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternLib._1创建型._05原型模式
{
    /// <summary>
    /// 在软件系统中，当创建一个类的实例很昂贵或很复杂，且需要创建多个这样类的实例时，如果我们用new操作符去创建这样的类实例，这未免会增加创建类的复杂度和耗费更多的内存空间，因为这样在内存中分配了多个一样的类实例对象。
    /// 如果采用工厂模式来创建这样的系统的话，随着产品类的不断增加，导致子类的数量不断增多，反而增加了系统复杂程度，所以在这里使用工厂模式来封装类创建过程并不合适。
    /// 然而原型模式可以很好地解决这个问题，因为每个类实例都是相同的，当我们需要多个相同的类实例时，没必要每次都使用new运算符去创建相同的类实例对象，此时我们一般思路就是想——只创建一个类实例对象，如果后面需要更多这样的实例，可以通过对原来对象拷贝一份来完成创建，这样在内存中不需要创建多个相同的类实例，从而减少内存的消耗和达到类实例的复用。
    /// </summary>
    public class PrototypeDemo
    {
        public static void PrototypeDemoTest()
        {
            string str = "原型模式应用案例！";

            APrototype ap = new ConcretePrototype(str);

            ConcretePrototype cp1=ap.Clone() as ConcretePrototype;
            Console.WriteLine("第一份浅副本：" + cp1.Str);

            ConcretePrototype cp2 = ap.Clone() as ConcretePrototype;
            Console.WriteLine("第二份浅副本：" + cp2.Str);
        }
    }
}
