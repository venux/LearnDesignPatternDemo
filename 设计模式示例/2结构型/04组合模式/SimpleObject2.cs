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
    public class SimpleObject2 : AComponent2
    {
        private string objName;

        public SimpleObject2(string objName)
        {
            this.objName = objName;
        }

        public override void Print()
        {
            Console.WriteLine("这是一个简单构件角色！名称为：" + objName);
        }
    }
}
