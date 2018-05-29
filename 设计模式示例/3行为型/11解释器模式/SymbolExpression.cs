using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternLib._3行为型._11解释器模式
{
    /// <summary>
    /// NonterminalExpression 非终结符表达式
    /// 文法中的每条规则对应于一个非终结表达式，具体到我们的例子就是加减法规则分别对应到AddExpression和SubExpression两个类。非终结符表达式根据逻辑的复杂程度而增加，原则上每个文法规则都对应一个非终结符表达式。 
    /// </summary>
    public abstract class SymbolExpression : AExpression
    {
        protected AExpression left, right;

        public SymbolExpression(AExpression left,AExpression right)
        {
            this.left = left;
            this.right = right;
        }
    }
}
