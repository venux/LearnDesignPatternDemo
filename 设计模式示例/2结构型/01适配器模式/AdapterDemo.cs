using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternLib._2结构型._01适配器模式
{
    /// <summary>
    /// 适配器模式
    /// 把一个类的接口变换成客户端所期待的另一种接口，从而使原本接口不匹配而无法一起工作的两个类能够在一起工作。适配器模式有类的适配器模式和对象的适配器模式两种形式。
    /// </summary>
    public class AdapterDemo
    {
        /// <summary>
        /// 在这里以生活中的一个例子来进行演示适配器模式的实现，
        /// 具体场景是: 在生活中，我们买的电器插头是2个孔的，但是我们买的插座只有三个孔的，此时我们就希望电器的插头可以转换为三个孔的就好，这样我们就可以直接把它插在插座上，此时三个孔插头就是客户端期待的另一种接口，自然两个孔的插头就是现有的接口，适配器模式就是用来完成这种转换的。
        /// </summary>
        public static void AdapterDemoTest()
        {
            Console.WriteLine("------------类的适配器------------");
            ClassAdapter adapter = new ClassAdapter();
            adapter.SpecificRequest();//两孔插头
            adapter.Request();//三孔插座
            
            Console.WriteLine("------------对象的适配器------------");
            ObjectAdapter objectAdapter = new ObjectAdapter();
            objectAdapter.Request();
        }
    }
}
