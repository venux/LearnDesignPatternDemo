﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternLib._3行为型._08责任链模式
{
    public class Level2Handler : AHandler
    {
        public override void HandleRequest(int requestNum)
        {
            if (requestNum > 3 && requestNum <= 5)
                Console.WriteLine("【大于3且小于等于5的由{0}处理，此处为{1}。】", this, requestNum);
            else
                this.NextHandler?.HandleRequest(requestNum);
        }
    }
}
