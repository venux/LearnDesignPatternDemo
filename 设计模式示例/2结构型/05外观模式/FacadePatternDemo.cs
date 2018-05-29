using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternLib._2结构型._05外观模式
{
    public class FacadePatternDemo
    {
        public static void FacadePatternDemoTest()
        {
            FacadeHelper helper = new FacadeHelper();
            helper.Method();
        }
    }
}
