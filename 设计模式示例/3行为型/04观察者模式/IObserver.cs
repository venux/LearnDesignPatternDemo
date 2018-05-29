﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternLib._3行为型._04观察者模式
{
    /// <summary>
    /// 抽象观察者（Observer）角色
    /// 为所有的具体观察者定义一个接口，在得到主题的通知时更新自己。这个接口叫做更新接口。抽象观察者角色一般用一个抽象类或者一个接口实现。在这个示意性的实现中，更新接口只包含一个方法（即Update()方法），这个方法叫做更新方法。
    /// </summary>
    public interface IObserver
    {
        void Update();
    }
}
