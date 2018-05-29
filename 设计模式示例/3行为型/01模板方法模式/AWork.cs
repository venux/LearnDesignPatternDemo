using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternLib._3行为型._01模板方法模式
{
    public abstract class AWork
    {
        public void BeforeWork()
        {
            Console.WriteLine("上班!");
        }

        public abstract void Work();

        public void AfterWork()
        {
            Console.WriteLine("下班！");
        }

        public void Print()
        {
            BeforeWork();
            Work();
            AfterWork();
        }
    }
}
