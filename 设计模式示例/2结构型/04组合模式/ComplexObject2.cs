using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternLib._2结构型._04组合模式
{
    /// <summary>
    /// 复杂构件角色
    /// 由多个简单构件角色或复杂构件角色合成
    /// </summary>
    public class ComplexObject2 : AComponent2
    {
        private List<AComponent1> compList = new List<AComponent1>();
        private string objName;

        public ComplexObject2(string objName)
        {
            this.objName = objName;
        }


        public override void Print()
        {
            Console.WriteLine("这是一个复杂的构件角色！名称为：" + objName);
        }

        public void Add(AComponent1 comp)
        {
            compList.Add(comp);
            Console.WriteLine("添加一个构件角色！");
        }

        public void Remove(AComponent1 comp)
        {
            compList.Remove(comp);
            Console.WriteLine("移除一个构件角色！");
        }

        public void GetChildred()
        {
            foreach (AComponent1 comp in compList)
                comp.Print();
        }
    }
}
