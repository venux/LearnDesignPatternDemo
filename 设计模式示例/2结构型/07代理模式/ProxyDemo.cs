using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternLib._2结构型._07代理模式
{
    public class ProxyDemo
    {
        public static void ProxyDemoTest()
        {
            //代理主题角色提供一个与真实主题角色相同的接口，以便可以在任何时候都可以替代真实主体。
            APerson Person = new ProxyPerson();

            Person.Print();
        }
    }
}
