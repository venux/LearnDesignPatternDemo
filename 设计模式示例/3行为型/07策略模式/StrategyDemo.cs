using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternLib._3行为型._07策略模式
{
    public class StrategyDemo
    {
        public static void StrategyDemoTest()
        {
            ITaxStragety personTaxStragety = new PersonTaxStrategy();
            ITaxStragety enterpriseTaxStragety = new EnterpriseTaxStrategy();

            TaxCalculater tc = new TaxCalculater(personTaxStragety);
            Console.WriteLine("10000元个人交税：" + tc.GetTax(10000)+"元。");

            tc = new TaxCalculater(enterpriseTaxStragety);
            Console.WriteLine("10000元企业交税：" + tc.GetTax(10000) + "元。");
        }
    }
}
