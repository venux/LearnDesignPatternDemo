using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternLib._3行为型._07策略模式
{
    /// <summary>
    /// 抽象策略角色（Strategy）：这是一个抽象角色，通常由一个接口或抽象类来实现。
    /// 此角色给出所有具体策略类所需实现的接口。
    /// </summary>
    public interface ITaxStragety
    {
        double CalculateTax(double income);
    }
}
