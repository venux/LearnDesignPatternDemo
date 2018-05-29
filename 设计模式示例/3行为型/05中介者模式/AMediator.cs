using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternLib._3行为型._05中介者模式
{
    /// <summary>
    /// 抽象中介类
    /// </summary>
    public abstract class AMediator
    {
        private ACardPlayer playerA, playerB;

        public ACardPlayer PlayerA
        {
            get
            {
                return this.playerA;
            }
        }

        public ACardPlayer PlayerB
        {
            get
            {
                return this.playerB;
            }
        }

        public AMediator(ACardPlayer playerA, ACardPlayer playerB)
        {
            this.playerA = playerA;
            this.playerB = playerB;
        }

        public abstract void AWin(int count);
        public abstract void BWin(int count);

    }
}
