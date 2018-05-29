using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternLib._1创建型._04建造者模式
{
    /// <summary>
    /// 项目
    /// </summary>
    public class Project
    {
        private List<string> list = new List<string>();

        public void AddItem(string item)
        {
            list.Add(item);
        }

        public void Show()
        {
            Console.WriteLine("------------开始------------");

            foreach (var item in list)
                Console.WriteLine(item);

            Console.WriteLine("------------结束------------");
            Console.WriteLine();
        }
    }
}
