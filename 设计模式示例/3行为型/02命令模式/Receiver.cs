using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternLib._3行为型._02命令模式
{
    /// <summary>
    /// 接收者
    /// 负责具体实施和执行一个请求。任何一个类都可以成为接收者，实施和执行请求的方法叫做行动方法。 
    /// </summary>
    public class Receiver
    {
        public Receiver()
        {
            Console.WriteLine("新建一个接受者！");
        }

        public void Print()
        {
            Console.WriteLine("接收者接收到命令！");
        }
    }
}
