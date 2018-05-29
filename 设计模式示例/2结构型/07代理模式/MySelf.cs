using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternLib._2结构型._07代理模式
{
    /// <summary>
    /// 源角色
    /// </summary>
    public class MySelf:APerson
    {
        public override void Print()
        {
            Console.WriteLine("本人今天有事，找个代理人帮我~");
        }
    }
}
