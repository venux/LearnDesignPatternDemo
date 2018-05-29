using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternLib._1创建型._01单例模式
{
    /// <summary>
    /// 第四种：线程安全、不使用锁、静态初始化
    /// 备注：静态初始化的方式是在自己的字段被引用时才会实例化,添加了静态构造函数当静态字段被引用时才进行初始化，因此即便很多线程试图引用_instance，也需要等静态构造函数执行完并把静态成员_instance实例化之后可以使用。
    ///As you can see, this is really is extremely simple - but why is it thread-safe and how lazy is it? Well, static constructors in C# are specified to
    ///execute only when an instance of the class is created or a static member is referenced, and to execute only once per AppDomain. Given that this check for the type
    ///being newly constructed needs to be executed whatever else happens, it will be faster than adding extra checking as in the previous examples. There are a couple of 
    ///wrinkles, however:
    ///1.It's not as lazy as the other implementations. In particular, if you have static members other than Instance, the first reference to those members will involve 
    ///creating the instance. This is corrected in the next implementation.
    ///2.There are complications if one static constructor invokes another which invokes the first again.Look in the.NET specifications (currently section 9.5.3 of partition 
    ///II) for more details about the exact nature of type initializers - they're unlikely to bite you, but it's worth being aware of the consequences of static constructors
    ///which refer to each other in a cycle.
    ///3.The laziness of type initializers is only guaranteed by.NET when the type isn't marked with a special flag called beforefieldinit. Unfortunately, the C# compiler 
    ///(as provided in the .NET 1.1 runtime, at least) marks all types which don't have a static constructor(i.e.a block which looks like a constructor but is marked static)
    ///as beforefieldinit.I now have an article with more details about this issue.Also note that it affects performance, as discussed near the bottom of the page.
    ///One shortcut you can take with this implementation (and only this one) is to just make instance a public static readonly variable, and get rid of the property entirely.
    ///This makes the basic skeleton code absolutely tiny!Many people, however, prefer to have a property in case further action is needed in future, and JIT inlining is
    ///likely to make the performance identical. (Note that the static constructor itself is still required if you require laziness.) 
    /// </summary>
    public sealed class Sington4
    {
        private static Sington4 instance = null;

        /// <summary>
        /// 添加一个静态构造函数，用于屏蔽IL将变量属性自动标记beforefieldinit。
        /// Explicit static constructor to tell C# compiler not to mark type as beforefieldinit
        /// </summary>
        static Sington4()
        {

        }

        private Sington4()
        {

        }

        public Sington4 Instance
        {
            get
            {
                if (instance == null)
                    instance = new Sington4();

                return instance;
            }
        }
    }
}
