using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternLib._2结构型._04组合模式
{
    /// <summary>
    /// 组合模式--抽象构建角色
    /// 安全:
    /// 将简单模型和复杂模型的共有方法统一写到抽象类中，而将新增、删除和遍历单独写到复杂模型中。 
    /// </summary>
    public abstract class AComponent2
    {
        public abstract void Print();
    }
}
