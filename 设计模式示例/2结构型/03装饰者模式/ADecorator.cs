using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternLib._2结构型._03装饰者模式
{
    /// <summary>
    /// 抽象装饰角色
    /// </summary>
    public class ADecorator : APhone
    {
        private APhone phone;

        public ADecorator(APhone phone)
        {
            this.phone = phone;
        }

        public override void Print()
        {
            if (phone != null)
                phone.Print();
        }
    }
}
