using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternLib._1创建型._01单例模式
{
    /// <summary>
    /// 第一种：线程不安全，不建议使用
    /// 【建议】：使用sealed关键字标识类不可继承，单例模式的类不应该继承，否则每个子类都可创建实例，违反唯一实例原则。
    /// 备注：只适用于单线程，多线程由于未加锁，导致各个线程都会创建一个实例，违反单例模式的基本原则。
    /// As hinted at before, the above is not thread-safe. Two different threads could both have evaluated the test if (instance==null) and found it to be true, then both create instances, which violates the singleton pattern. Note that in fact the instance may already have been created before the expression is evaluated, but the memory model doesn't guarantee that the new value of instance will be seen by other threads unless suitable memory barriers have been passed.
    /// </summary>
    public sealed class Sington1
    {
        private static Sington1 instance = null;

        private Sington1()
        {

        }

        public Sington1 Instance
        {
            get
            {
                if (instance == null)
                    instance = new Sington1();

                return instance;
            }
        }
    }
}
