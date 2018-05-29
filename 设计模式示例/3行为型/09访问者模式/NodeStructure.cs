using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternLib._3行为型._09访问者模式
{
    /// <summary>
    /// 结构对象（ObjectStructure）角色：有如下的一些责任，可以遍历结构中的所有元素；如果需要，提供一个高层次的接口让访问者对象可以访问每一个元素；如果需要，可以设计成一个复合对象或者一个聚集，如列（List）或集合（Set）。
    /// </summary>
    public class NodeStructure
    {
        private ArrayList elements = new ArrayList();

        public void Add(ANode node)
        {
            elements.Add(node);
        }

        public void Delete(ANode node)
        {
            elements.Remove(node);
        }

        public void Accept(AVistor vistor)
        {
            foreach (var element in elements)
            {
                var node = element as ANode;

                node?.Accept(vistor);
            }
        }
    }
}
