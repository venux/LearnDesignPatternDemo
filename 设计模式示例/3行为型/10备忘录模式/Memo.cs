using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternLib._3行为型._10备忘录模式
{
    /// <summary>
    /// 备忘录角色：负责存储发起人对象的内部状态，在进行恢复时提供给发起人需要的状态。
    /// </summary>
    public class Memo
    {
        private List<Person> persons = new List<Person>();
        /// <summary>
        /// 联系人集合
        /// </summary>
        public List<Person> Persons
        {
            get
            {
                return persons;
            }
            set
            {
                persons = value;
            }
        }
    }
}
