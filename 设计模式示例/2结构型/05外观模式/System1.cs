using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternLib._2结构型._05外观模式
{
    /// <summary>
    /// 子系统（subsystem）角色：可以同时包含一个或多个子系统。
    /// 每个子系统都不是一个单独的类，而是一个类的集合。
    /// 每个子系统都可以被客户端直接调用或被门面角色调用。
    /// 对于子系统而言，门面仅仅是另外一个客户端，子系统并不知道门面的存在。
    /// </summary>
    public class System1
    {
        public void Method1()
        {
            Console.WriteLine("第一个子系统的方法！");
        }
    }
}
