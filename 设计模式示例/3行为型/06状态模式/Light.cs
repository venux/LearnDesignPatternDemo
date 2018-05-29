using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternLib._3行为型._06状态模式
{
    /// <summary>
    /// 具体角色，包含状态
    /// </summary>
    public class Light
    {
        private AState state;

        public AState State
        {
            get
            {
                return this.state;
            }
            set
            {
                this.state = value;
            }
        }

        public Light(AState state)
        {
            this.state = state;
        }

        /// <summary>
        /// 按下灯按钮切换状态
        /// </summary>
        public void PressSwitch()
        {
            this.state.PressSwitch(this);
        }
    }
}
