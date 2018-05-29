using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternLib._3行为型._11解释器模式
{
    public class MinusExpression : SymbolExpression
    {
        public MinusExpression(AExpression left, AExpression right) : base(left, right)
        {

        }

        public override int Interpreter(Context context)
        {
            return this.left.Interpreter(context) - this.right.Interpreter(context);
        }
    }
}
