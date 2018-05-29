using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternLib._3行为型._03迭代器模式
{
    /// <summary>
    /// •迭代器角色（Iterator）：迭代器角色负责定义访问和遍历元素的接口
    /// </summary>
    public interface IIterator
    {
        bool MoveNext();

        Object GetCurrent();

        void Next();

        void Reset();
    }
}
