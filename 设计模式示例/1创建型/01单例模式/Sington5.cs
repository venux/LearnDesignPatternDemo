using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternLib._1创建型._01单例模式
{
    /// <summary>
    /// 第五种：线程安全、延迟初始化
    /// 备注：把初始化工作放到Nested类中的一个静态成员来完成，这样就实现了延迟初始化。
    /// Here, instantiation is triggered by the first reference to the static member of the nested class, which only occurs in Instance. This means the implementation is fully lazy, but has all the performance benefits of the previous ones. Note that although nested classes have access to the enclosing class's private members, the reverse is not true, hence the need for instance to be internal here. That doesn't raise any other problems, though, as the class itself is private. The code is a bit more complicated in order to make the instantiation lazy, however.
    /// </summary>
    public sealed class Sington5
    {
        private Sington5()
        {

        }

        public Sington5 Instance
        {
            get
            {
                return SingtonNested.instance;
            }
        }

        internal class SingtonNested
        {
            internal static Sington5 instance = new Sington5();

            // Explicit static constructor to tell C# compiler not to mark type as beforefieldinit
            static SingtonNested()
            {

            }
        }
    }
}
