using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternLib._2结构型._07代理模式
{
    /// <summary>
    /// 代理角色
    /// </summary>
    public class ProxyPerson : APerson
    {
        private MySelf me = null;

        public override void Print()
        {
            Console.WriteLine("我是代理人~");

            if (me == null)
                me = new MySelf();

            PrepareProxy();

            me.Print();

            EndProxy();
        }

        private void PrepareProxy()
        {
            Console.WriteLine("代理人代理前执行的事件！");
        }

        private void EndProxy()
        {
            Console.WriteLine("代理人代理后执行的事件！");
        }
    }
}
