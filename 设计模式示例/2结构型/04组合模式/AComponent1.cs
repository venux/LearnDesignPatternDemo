using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternLib._2结构型._04组合模式
{
    /// <summary>
    /// 组合模式--抽象构建角色
    /// 透明式:
    /// 将简单模型和复杂模型的所有方法统一写到抽象类中
    /// 作为第一种选择，在Component里面声明所有的用来管理子类对象的方法，包括add（）、remove（），以及getChild（）方法。
    /// 这样做的好处是所有的构件类都有相同的接口。
    /// 在客户端看来，树叶类对象与合成类对象的区别起码在接口层次上消失了，客户端可以同等同的对待所有的对象。
    /// 这就是透明形式的合成模式。
    /// </summary>
    public abstract class AComponent1
    {
        public abstract void Print();

        public abstract void Add(AComponent1 comp);

        public abstract void Remove(AComponent1 comp);

        public abstract void GetChildred();
    }
}
