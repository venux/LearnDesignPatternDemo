using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternLib._2结构型._05外观模式
{
    /// <summary>
    /// 外观类--门面角色
    /// 客户端调用这个角色的方法。该角色知道相关的一个或多个子系统的功能和责任，该角色会将从客户端发来的请求委派带相应的子系统中去。
    /// </summary>
    public class FacadeHelper
    {
        public void Method()
        {
            System1 sys1 = new System1();
            sys1.Method1();

            System2 sys2 = new System2();
            sys2.Method2();

            System3 sys3 = new System3();
            sys3.Method3();
        }
    }
}
