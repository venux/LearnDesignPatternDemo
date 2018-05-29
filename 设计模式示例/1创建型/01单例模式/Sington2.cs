using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternLib._1创建型._01单例模式
{
    /// <summary>
    /// 第二种：简单版线程安全
    /// 备注：该版本代码对于每个线程都会对线程辅助对象locker加锁之后再判断实例是否存在，对于这个操作完全没有必要的，因为当第一个线程创建了该类的实例之后，后面的线程此时只需要直接判断（uniqueInstance==null）为假，此时完全没必要对线程辅助对象加锁之后再去判断，所以上面的实现方式增加了额外的开销，损失了性能。
    /// This implementation is thread-safe. The thread takes out a lock on a shared object, and then checks whether or not the instance has been created before creating the instance. This takes care of the memory barrier issue (as locking makes sure that all reads occur logically after the lock acquire, and unlocking makes sure that all writes occur logically before the lock release) and ensures that only one thread will create an instance (as only one thread can be in that part of the code at a time - by the time the second thread enters it,the first thread will have created the instance, so the expression will evaluate to false). Unfortunately, performance suffers as a lock is acquired every time the instance is requested.
    /// Note that instead of locking on typeof(Singleton) as some versions of this implementation do, I lock on the value of a static variable which is private to the class. Locking on objects which other classes can access and lock on(such as the type) risks performance issues and even deadlocks.This is a general style preference of mine - wherever possible, only lock on objects specifically created for the purpose of locking, or which document that they are to be locked on for specific purposes (e.g. for waiting/pulsing a queue). Usually such objects should be private to the class they are used in. This helps to make writing thread-safe applications significantly easier.
    /// </summary>
    public sealed class Sington2
    {
        private static Sington2 instance = null;
        // 定义一个标识确保线程同步
        private static readonly object lockObj = null;

        private Sington2()
        {

        }

        public Sington2 Instance
        {
            get
            {
                // 当第一个线程运行到这里时，此时会对locker对象 "加锁"，
                // 当第二个线程运行该方法时，首先检测到locker对象为"加锁"状态，该线程就会挂起等待第一个线程解锁
                // lock语句运行完之后（即线程运行完之后）会对该对象"解锁"
                lock (lockObj)
                {
                    if (instance == null)
                        instance = new Sington2();

                    return instance;
                }
            }
        }
    }
}
