using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternLib._3行为型._01模板方法模式
{
    public class Illustrator : AWork
    {
        public override void Work()
        {
            Console.WriteLine("插画师工作内容：画画!");
        }
    }
}
