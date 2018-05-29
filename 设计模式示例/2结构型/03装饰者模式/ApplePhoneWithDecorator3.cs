using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternLib._2结构型._03装饰者模式
{
    public class ApplePhoneWithDecorator3 : ADecorator
    {
        public ApplePhoneWithDecorator3(APhone aphone) : base(aphone)
        {

        }


        public override void Print()
        {
            base.Print();

            AddDecorator3();
        }

        public void AddDecorator3()
        {
            Console.WriteLine("装饰3");
        }
    }
}
