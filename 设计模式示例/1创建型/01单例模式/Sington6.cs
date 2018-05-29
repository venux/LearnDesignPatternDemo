using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DesignPatternLib._1创建型._01单例模式
{
    /// <summary>
    /// 第六种：using .NET 4's Lazy<T> type
    /// 备注：简单和性能良好，而且还提供检查是否已经创建实例的属性IsValueCreated。
    /// If you're using .NET 4 (or higher), you can use the System.Lazy<T> type to make the laziness really simple. 
    /// All you need to do is pass a delegate to the constructor which calls the Singleton constructor - which is done most easily with a lambda expression.
    /// It's simple and performs well. It also allows you to check whether or not the instance has been created yet with the IsValueCreated property, if you need that.
    /// </summary>
    public sealed class Sington6
    {
        private static readonly Lazy<Sington6> lazy = new Lazy<Sington6>(() => new Sington6(), true);

        private Sington6()
        {

        }

        public Sington6 Instance
        {
            get
            {
                return lazy.Value;
            }
        }       
    }
}
