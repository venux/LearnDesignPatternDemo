using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternLib._3行为型._03迭代器模式
{
    /// <summary>
    /// 聚合角色（Aggregate）：聚合角色负责定义获得迭代器角色的接口
    /// </summary>
    public interface IListCollection
    {    
        IIterator GetIterator();
    }
}
