using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternLib._2结构型._07代理模式.远程代理例子
{
    public class MathProxyDemo
    {
        public static void MathProxyDemoTest()
        {
            MathProxy mathProxy = new MathProxy();
            Console.WriteLine("10+5={0}", mathProxy.Add(10, 5));
            Console.WriteLine("10-5={0}", mathProxy.Sub(10, 5));
            Console.WriteLine("10*5={0}", mathProxy.Mul(10, 5));
            Console.WriteLine("10/5={0}", mathProxy.Div(10, 5));
        }
    }
}
