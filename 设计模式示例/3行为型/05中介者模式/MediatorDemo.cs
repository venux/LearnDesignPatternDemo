using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternLib._3行为型._05中介者模式
{
    public class MediatorDemo
    {
        public static void MediatorDemoTest()
        {
            ACardPlayer playerA = new CardPlayerA();
            ACardPlayer playerB = new CardPlayerB();

            playerA.MoneyNum = 100;
            playerB.MoneyNum = 100;

            AMediator mediator = new MediatorPlayer(playerA, playerB);

            mediator.AWin(50);

            Console.WriteLine("A赢了50元，此刻A有{0}元，B有{1}元。", playerA.MoneyNum, playerB.MoneyNum);

            mediator.BWin(150);

            Console.WriteLine("B赢回150元，此刻A有{0}元，B有{1}元。", playerA.MoneyNum, playerB.MoneyNum);
        }
    }
}
