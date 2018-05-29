using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternLib._3行为型._02命令模式
{
    /// <summary>
    /// 请求者角色
    /// 负责调用命令对象执行请求，相关的方法叫做行动方法。 
    /// </summary>
    public class Invoker
    {
        private ACommand command;

        public void SetCommand(ACommand command)
        {
            this.command = command;

            Console.WriteLine("创建请求者角色！");
        }

        public void ExecuteCommand()
        {
            this.command?.Execute();
        }
    }
}
