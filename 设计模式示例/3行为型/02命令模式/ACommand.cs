using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternLib._3行为型._02命令模式
{
    /// <summary>
    /// 抽象命令角色
    /// 声明了一个给所有具体命令类的抽象接口。这是一个抽象角色。 
    /// </summary>
    public abstract class ACommand
    {
        protected Receiver receiver = null;

        public ACommand(Receiver receiver)
        {
            this.receiver = receiver;
        }

        /// <summary>
        /// 命令执行
        /// </summary>
        public abstract void Execute();
    }
}
