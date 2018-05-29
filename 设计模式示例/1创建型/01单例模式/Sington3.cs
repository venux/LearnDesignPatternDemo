using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternLib._1创建型._01单例模式
{
    /// <summary>
    /// 第三种：线程安全、双重锁定
    /// 备注：该版本代码为了改进上面实现方式的缺陷，我们只需要在lock语句前面加一句判断就可以避免锁所增加的额外开销，这种实现方式我们就叫它 “双重锁定”。
    /// This implementation attempts to be thread-safe without the necessity of taking out a lock every time. Unfortunately, there are four downsides to the pattern:
    ///1.It doesn't work in Java. This may seem an odd thing to comment on, but it's worth knowing if you ever need the singleton pattern in Java, and C# programmers may well also be Java programmers. The Java memory model doesn't ensure that the constructor completes before the reference to the new object is assigned to instance. The Java memory model underwent a reworking for version 1.5, but double-check locking is still broken after this without a volatile variable (as in C#).
    ///2.Without any memory barriers, it's broken in the ECMA CLI specification too. It's possible that under the.NET 2.0 memory model(which is stronger than the ECMA spec) it's safe, but I'd rather not rely on those stronger semantics, especially if there's any doubt as to the safety. Making the instance variable volatile can make it work, as would explicit memory barrier calls, although in the latter case even experts can't agree exactly which barriers are required.I tend to try to avoid situations where experts don't agree what's right and what's wrong!
    ///3.It's easy to get wrong. The pattern needs to be pretty much exactly as above - any significant changes are likely to impact either performance or correctness.
    ///4.It still doesn't perform as well as the later implementations./// </summary>
    public sealed class Sington3
    {
        private static Sington3 instance = null;
        // 定义一个标识确保线程同步
        private static readonly object lockObj = null;

        private Sington3()
        {

        }

        public Sington3 Instance
        {
            get
            {
                // 当第一个线程运行到这里时，此时会对locker对象 "加锁"，
                // 当第二个线程运行该方法时，首先检测到locker对象为"加锁"状态，该线程就会挂起等待第一个线程解锁
                // lock语句运行完之后（即线程运行完之后）会对该对象"解锁"
                // 双重锁定只需要一句判断就可以了
                if (instance == null)
                {
                    lock (lockObj)
                    {
                        if (instance == null)
                            instance = new Sington3();
                    }
                }

                return instance;
            }
        }
    }
}
