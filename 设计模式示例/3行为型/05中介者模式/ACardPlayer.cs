using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternLib._3行为型._05中介者模式
{
    /// <summary>
    /// 抽象牌友
    /// </summary>
    public abstract class ACardPlayer
    {
        public int MoneyNum
        {
            get;
            set;
        }

        public ACardPlayer()
        {
            MoneyNum = 0;
        }

        public abstract void ChangeCount(int Count, AMediator mediator);
    }
}
