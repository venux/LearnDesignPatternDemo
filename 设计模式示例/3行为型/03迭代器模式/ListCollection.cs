using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternLib._3行为型._03迭代器模式
{
    public class ListCollection : IListCollection
    {
        int[] collection;

        public ListCollection()
        {
            collection = new int[] { 2, 4, 6, 8, 10 };
        }

        public IIterator GetIterator()
        {
            return new Iterator(this);
        }

        public int Length
        {
            get
            {
                return collection.Length;
            }
        }

        public int GetElement(int index)
        {
            return collection[index];
        }
    }
}
