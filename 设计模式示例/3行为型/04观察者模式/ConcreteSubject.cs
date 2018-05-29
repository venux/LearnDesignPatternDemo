using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternLib._3行为型._04观察者模式
{
    public class ConcreteSubject : ASubject
    {
        /// <summary>
        /// 具体主题（ConcreteSubject）角色
        /// 将有关状态存入具体现察者对象；在具体主题的内部状态改变时，给所有登记过的观察者发出通知。具体主题角色又叫做具体被观察者角色（Concrete Observable）。具体主题角色通常用一个具体子类实现。
        /// </summary>
        public string SubjectState
        {
            get;
            set;
        }
    }
}
