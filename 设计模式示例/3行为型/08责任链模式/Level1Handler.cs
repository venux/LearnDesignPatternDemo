using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternLib._3行为型._08责任链模式
{
    /// <summary>
    /// 具体处理者(ConcreteHandler)角色：具体处理者接到请求后，可以选择将请求处理掉，或者将请求传给下家。由于具体处理者持有对下家的引用，因此，如果需要，具体处理者可以访问下家。
    /// </summary>
    public class Level1Handler : AHandler
    {
        public override void HandleRequest(int requestNum)
        {
            if (requestNum <= 3)
                Console.WriteLine("【小于等于3的由{0}处理，此处为{1}。】", this, requestNum);
            else
                this.NextHandler?.HandleRequest(requestNum);
        }
    }
}
