using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternLib._3行为型._04观察者模式
{
    /// <summary>
    /// 抽象主题（Subject）角色
    /// 主题角色把所有对观察考对象的引用保存在一个聚集里，每个主题都可以有任何数量的观察者。抽象主题提供一个接口，可以增加和删除观察者对象，主题角色又叫做抽象被观察者（Observable）角色，一般用一个抽象类或者一个接口实现。
    /// </summary>
    public abstract class ASubject
    {
        private List<IObserver> observerList = new List<IObserver>();

        public void AddObserver(IObserver observer)
        {
            observerList.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            observerList.Remove(observer);
        }

        public void Notify()
        {
            foreach (IObserver observer in observerList)
                observer.Update();
        }
    }
}
