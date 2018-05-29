using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternLib._3行为型._11解释器模式
{
    public class Calculator
    {
        private Context context = new Context();

        public Calculator()
        {
            context.Data.Add("a", 1);
            context.Data.Add("b", 2);
            context.Data.Add("c", 3);
        }

        public void Test()
        {
            AExpression aVar = new VarExpression("a");
            AExpression bVar = new VarExpression("b");
            AExpression cVar = new VarExpression("c");

            AExpression addExp = new AddExpression(aVar, bVar);
            AExpression minusExp = new MinusExpression(bVar, cVar);

            AExpression minusExp2 = new MinusExpression(addExp, minusExp);

            int result = minusExp2.Interpreter(context);

            Console.WriteLine("(1+2)-(2-3)={0}", result);
        }
    }
}
