using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternLib._3行为型._02命令模式
{
    /// <summary>
    /// 客户（Client）角色
    /// 创建了一个具体命令(ConcreteCommand)对象并确定其接收者。 
    /// </summary>
    public class CommandDemo
    {
        public static void CommandDemoTest()
        {
            Console.WriteLine("客户端开始调用命令！");

            Receiver receiver = new Receiver();

            ACommand command = new ConcreteCommand(receiver);

            Invoker invoker = new Invoker();
            invoker.SetCommand(command);
            invoker.ExecuteCommand();
        }
    }
}
