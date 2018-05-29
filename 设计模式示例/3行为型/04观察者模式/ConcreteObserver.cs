using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternLib._3行为型._04观察者模式
{
    /// <summary>
    /// 具体观察者（ConcreteObserver）角色
    /// 存储与主题的状态自恰的状态。具体现察者角色实现抽象观察者角色所要求的更新接口，以便使本身的状态与主题的状态相协调。如果需要，具体现察者角色可以保存一个指向具体主题对象的引用。具体观察者角色通常用一个具体子类实现。
    /// </summary>
    public class ConcreteObserver : IObserver
    {
        private string name;

        private ConcreteSubject subject;

        public ConcreteSubject Subject
        {
            get
            {
                return subject;
            }
            set
            {
                subject = value;
            }
        }

        public ConcreteObserver(string name, ConcreteSubject subject)
        {
            this.name = name;
            this.subject = subject;
        }

        public void Update()
        {
            Console.WriteLine("观察者{0}更新状态{1}！", name, subject.SubjectState);
        }
    }
}
