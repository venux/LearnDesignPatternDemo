using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternLib._3行为型._11解释器模式
{
    /// <summary>
    /// 环境角色(Context): 包含解释器之外的一些全局信息.
    /// </summary>
    public class Context
    {
        private Dictionary<string, int> data = new Dictionary<string, int>();

        public Dictionary<string, int> Data
        {
            get
            {
                return data;
            }

            set
            {
                data = value;
            }
        }
    }
}
