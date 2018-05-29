using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternLib._3行为型._11解释器模式
{
    /// <summary>
    /// 抽象表达式角色(AbstractExpression): 声明一个抽象的解释操作,这个接口为所有具体表达式角色都要实现的.
    /// </summary>
    public abstract class AExpression
    {
        public abstract int Interpreter(Context context);
    }
}
