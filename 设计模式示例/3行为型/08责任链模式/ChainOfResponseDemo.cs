using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternLib._3行为型._08责任链模式
{
    /// <summary>
    /// 责任链模式
    /// 一种对象的行为模式【GOF95】。在责任链模式里，很多对象由每一个对象对其下家的引用而连接起来形成一条链。请求在这个链上传递，直到链上的某一个对象决定处理此请求。发出这个请求的客户端并不知道链上的哪一个对象最终处理这个请求，这使得系统可以在不影响客户端的情况下动态地重新组织链和分配责任。
    /// </summary>
    public class ChainOfResponseDemo
    {
        public static void ChainOfResponseDemoTest()
        {
            AHandler handle1 = new Level1Handler();
            AHandler handle2 = new Level2Handler();
            AHandler handle3 = new Level3Handler();

            handle1.NextHandler = handle2;
            handle2.NextHandler = handle3;

            int[] requestNums = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            foreach (int requestNum in requestNums)
            {
                handle1.HandleRequest(requestNum);
            }
        }
    }
}
