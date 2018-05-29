using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternLib._3行为型._11解释器模式
{
    /// <summary>
    /// TerminalExpression终结符表达式
    /// 实现与文法中的元素相关联的解释操作，通常一个解释器模式中只有一个终结符表达式，但有多个实例，对应不同的终结符。具体到我们例子就是VarExpression类，表达式中的每个终结符都在堆栈中产生了一个VarExpression对象。 
    /// </summary>
    public class VarExpression : AExpression
    {
        private string key;

        public VarExpression(string key)
        {
            this.key = key;
        }


        public override int Interpreter(Context context)
        {
            return context.Data[this.key];
        }
    }
}
