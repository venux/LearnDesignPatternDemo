using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternLib._2结构型._01适配器模式
{
    /// <summary>
    /// 适配源
    /// 类适配器
    /// </summary>
    public abstract class AdapteeBase
    {
        public void SpecificRequest()
        {
            Console.WriteLine("适配源，被适配！");
        }
    }

    /// <summary>
    /// 适配源
    /// 对象适配器
    /// </summary>
    public class Adaptee
    {
        public void SpecificRequest()
        {
            Console.WriteLine("适配源，被适配！");
        }
    }
}
