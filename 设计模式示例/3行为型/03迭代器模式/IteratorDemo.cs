using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternLib._3行为型._03迭代器模式
{
    public class IteratorDemo
    {
        public static void IteratorDemoTest()
        {
            IListCollection list = new ListCollection();
            IIterator iterator = list.GetIterator();

            while (iterator.MoveNext())
            {
                int tempNum = (int)iterator.GetCurrent();
                Console.WriteLine(tempNum);

                iterator.Next();
            }
        }
    }
}
