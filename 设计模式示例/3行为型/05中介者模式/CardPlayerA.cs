using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternLib._3行为型._05中介者模式
{
    public class CardPlayerA : ACardPlayer
    {
        public override void ChangeCount(int Count, AMediator mediator)
        {
            mediator.AWin(Count);
        }
    }
}
