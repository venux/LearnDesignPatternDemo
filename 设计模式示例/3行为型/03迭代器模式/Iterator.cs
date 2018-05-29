using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternLib._3行为型._03迭代器模式
{
    public class Iterator : IIterator
    {
        private ListCollection listCollection;
        private int index;

        public Iterator(ListCollection listCollection)
        {
            this.listCollection = listCollection;
        }

        public bool MoveNext()
        {
            return index < listCollection.Length;
        }

        public object GetCurrent()
        {
            return listCollection.GetElement(index);
        }

        public void Next()
        {
            if (index < listCollection.Length)
                index++;
        }

        public void Reset()
        {
            index = 0;
        }
    }
}
