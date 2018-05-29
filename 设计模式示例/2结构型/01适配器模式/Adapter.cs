using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternLib._2结构型._01适配器模式
{
    /// <summary>
    /// 适配器类--类的适配器模式
    /// 提供目标行为，本质确是源方法。
    /// 因为适配器与源角色是继承关系，所以该适配器模式是类的适配器模式
    /// </summary>
    public class ClassAdapter : AdapteeBase, ITarget
    {
        /// <summary>
        /// 实现三孔插座
        /// </summary>
        public void Request()
        {
            //调用两孔插头方法
            this.SpecificRequest();
        }
    }

    /// <summary>
    /// 适配器类--对象的适配器模式
    /// 思路：既然现在适配器类不能继承源了（因为用继承就属于类的适配器了），但是适配器类无论如何都要实现客户端期待的方法的，即Request方法，所以一定是要继承目标抽象类或接口的。
    /// 然而适配器类的Request方法又必须调用源的SpecificRequest方法，又不能用继承，我们可以在适配器类中创建源对象，然后在Requst中使用源的方法了。
    /// </summary>
    public class ObjectAdapter : ITarget
    {
        /// <summary>
        /// 实现目标要求
        /// </summary>
        public void Request()
        {
            Adaptee twohole = new Adaptee();
            //实现源行为
            twohole.SpecificRequest();            
        }
    }
}
