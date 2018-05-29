using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternLib._2结构型._04组合模式
{
    /// <summary>
    /// 简单构件角色
    /// </summary>
    public class SimpleObject1 : AComponent1
    {
        private string objName;

        public SimpleObject1(string objName)
        {
            this.objName = objName;
        }

        public override void Print()
        {
            Console.WriteLine("这是一个简单构件角色！名称为：" + objName);
        }

        public override void Add(AComponent1 comp)
        {
            Console.WriteLine("简单构件角色无需添加！");
        }

        public override void Remove(AComponent1 comp)
        {
            Console.WriteLine("简单构件角色无需删除！");
        }

        public override void GetChildred()
        {
            Console.WriteLine("简单构件角色无需遍历！");
        }
    }
}
