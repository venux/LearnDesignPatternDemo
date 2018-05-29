using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternLib._2结构型._03装饰者模式
{
    public class ApplePhoneWithDecorator2 : ADecorator
    {
        public ApplePhoneWithDecorator2(APhone aphone) : base(aphone)
        {

        }


        public override void Print()
        {
            base.Print();

            AddDecorator2();
        }

        public void AddDecorator2()
        {
            Console.WriteLine("装饰2");
        }
    }
}
