using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternLib._2结构型._03装饰者模式
{
    /// <summary>
    /// 装饰者模式
    /// 
    /// </summary>
    public class DecoratorDemo
    {
        public static void DecoratorDemoTest()
        {
            APhone phone = new ApplePhone();

            ADecorator d1 = new ApplePhoneWithDecorator1(phone);
            d1.Print();

            Console.WriteLine("-----------------");



            ADecorator d2 = new ApplePhoneWithDecorator2(phone);
            d2.Print();

            Console.WriteLine("-----------------");



            ADecorator d3 = new ApplePhoneWithDecorator3(phone);
            d3.Print();

            Console.WriteLine("-----------------");




            ADecorator d4 = new ApplePhoneWithDecorator3(d1);
            d4.Print();

            Console.WriteLine("-----------------");
        }
    }
}
