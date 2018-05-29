using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternLib._2结构型._03装饰者模式
{
    public class ApplePhoneWithDecorator1 : ADecorator
    {
        public ApplePhoneWithDecorator1(APhone aphone) : base(aphone)
        {

        }


        public override void Print()
        {
            base.Print();

            AddDecorator1();
        }

        public void AddDecorator1()
        {
            Console.WriteLine("装饰1");
        }
    }
}
