using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternLib._3行为型._06状态模式
{
    /// <summary>
    /// 抽象状态角色
    /// </summary>
    public abstract class AState
    {
        public abstract void PressSwitch(Light light);
    }
}
