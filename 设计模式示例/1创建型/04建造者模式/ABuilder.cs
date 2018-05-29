using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternLib._1创建型._04建造者模式
{
    /// <summary>
    /// 建造者抽象类
    /// </summary>
    public abstract class ABuilder
    {
        public abstract void TouBiao();
        public abstract void ZhongBiao();
        public abstract void SheJi();
        public abstract void KaiFa();
        public abstract void ShangXian();
        public abstract Project ShowProject();
    }
}
