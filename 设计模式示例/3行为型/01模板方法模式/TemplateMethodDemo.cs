using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternLib._3行为型._01模板方法模式
{
    public class TemplateMethodDemo
    {
        public static void TemplateMethodDemoTest()
        {
            AWork work1 = new Programmer();
            work1.Print();

            Console.WriteLine("------------------------");

            AWork work2 = new Illustrator();
            work2.Print();
        }
    }
}
