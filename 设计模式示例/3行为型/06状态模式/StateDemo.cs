
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternLib._3行为型._06状态模式
{
    public class StateDemo
    {
        public static void StateDemoTest()
        {
            Light light = new Light(new StateOn());
            light.PressSwitch();
            light.PressSwitch();
            light.PressSwitch();
            light.PressSwitch();
        }
    }
}
