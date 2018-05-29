using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternLib._3行为型._07策略模式
{
    /// <summary>
    /// 税收计算者
    /// </summary>
    public class TaxCalculater
    {
        private ITaxStragety taxStrategy;

        public TaxCalculater(ITaxStragety taxStrategy)
        {
            this.taxStrategy = taxStrategy;
        }

        public double GetTax(double income)
        {
            return this.taxStrategy.CalculateTax(income);
        }
    }
}
