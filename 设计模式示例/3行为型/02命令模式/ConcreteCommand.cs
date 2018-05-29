using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternLib._3行为型._02命令模式
{
    /// <summary>
    /// 具体命令（ConcreteCommand）角色
    /// 定义一个接受者和行为之间的弱耦合；实现Execute()方法，负责调用接收考的相应操作。Execute()方法通常叫做执方法。 
    /// </summary>
    public class ConcreteCommand : ACommand
    {
        public ConcreteCommand(Receiver receiver) : base(receiver)
        {
            Console.WriteLine("创建具体命令角色！");
        }

        public override void Execute()
        {
            receiver.Print();
        }
    }
}
