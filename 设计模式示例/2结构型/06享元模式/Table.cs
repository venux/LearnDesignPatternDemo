using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternLib._2结构型._06享元模式
{
    /// <summary>
    /// 外蕴状态--单纯享元模式
    /// </summary>
    public class Table
    {
        private int tableNum;

        public int TableNum
        {
            get
            {
                return tableNum;
            }
        }

        public Table(int tableNum)
        {
            this.tableNum = tableNum;
        }
    }
}
