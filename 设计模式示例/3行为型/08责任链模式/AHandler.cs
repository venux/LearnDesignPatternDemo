using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternLib._3行为型._08责任链模式
{
    /// <summary>
    /// 抽象处理者(Handler)角色：定义出一个处理请求的接口。如果需要，接口可以定义出一个方法，以设定和返回对下家的引用。这个角色通常由一个抽象类或接口实现。
    /// </summary>
    public abstract class AHandler
    {
        public AHandler NextHandler
        {
            get;
            set;
        }

        public abstract void HandleRequest(int requestNum);
    }
}
