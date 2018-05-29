using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternLib._3行为型._06状态模式
{
    public class StateOff:AState
    {
        public override void PressSwitch(Light light)
        {
            Console.WriteLine("灯灭~");

            light.State = new StateOn();
        }
    }
}
