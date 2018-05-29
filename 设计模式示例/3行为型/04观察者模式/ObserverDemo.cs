using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternLib._3行为型._04观察者模式
{
    public class ObserverDemo
    {
        public static void ObserverDemoTest()
        {
            ConcreteSubject subject = new ConcreteSubject();

            IObserver observer1 = new ConcreteObserver("A", subject);
            subject.AddObserver(observer1);

            IObserver observer2 = new ConcreteObserver("B", subject);
            subject.AddObserver(observer2);

            IObserver observer3 = new ConcreteObserver("C", subject);
            subject.AddObserver(observer3);

            subject.SubjectState = "【第一条通知，请注意查收！】";
            subject.Notify();

            subject.RemoveObserver(observer3);
            subject.SubjectState = "【C已滚出教室！】";
            subject.Notify();
        }
    }
}
