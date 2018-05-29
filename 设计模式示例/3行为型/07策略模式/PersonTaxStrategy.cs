using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternLib._3行为型._07策略模式
{
    /// <summary>
    /// 具体策略角色（ConcreteStrategy）：包装了相关算法或行为。
    /// </summary>
    public class PersonTaxStrategy : ITaxStragety
    {
        public double CalculateTax(double income)
        {
            return income * 0.12;
        }
    }
}
