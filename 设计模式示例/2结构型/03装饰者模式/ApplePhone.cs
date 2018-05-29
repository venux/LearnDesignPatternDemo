using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternLib._2结构型._03装饰者模式
{
    public class ApplePhone : APhone
    {
        public override void Print()
        {
            Console.WriteLine("苹果手机");
        }
    }
}
