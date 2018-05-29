using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternLib._3行为型._05中介者模式
{
    public class MediatorPlayer : AMediator
    {
        public MediatorPlayer(ACardPlayer playerA, ACardPlayer playerB) : base(playerA, playerB)
        {

        }

        public override void AWin(int count)
        {
            PlayerA.MoneyNum += count;
            PlayerB.MoneyNum -= count;
        }

        public override void BWin(int count)
        {
            PlayerA.MoneyNum -= count;
            PlayerB.MoneyNum += count;
        }
    }
}
