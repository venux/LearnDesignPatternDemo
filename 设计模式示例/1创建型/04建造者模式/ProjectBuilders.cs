using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternLib._1创建型._04建造者模式
{
    /// <summary>
    /// 建造者-发那科
    /// </summary>
    public class FanucBuilder : ABuilder
    {
        Project project = new Project();

        public override void TouBiao()
        {
            project.AddItem("发那科投标！");
        }

        public override void ZhongBiao()
        {
            project.AddItem("发那科中标！");
        }

        public override void SheJi()
        {
            project.AddItem("发那科设计！");
        }

        public override void KaiFa()
        {
            project.AddItem("发那科开发！");
        }

        public override void ShangXian()
        {
            project.AddItem("发那科上线！");
        }

        public override Project ShowProject()
        {
            return project;
        }
    }

    /// <summary>
    /// 建造者-发那科
    /// </summary>
    public class IllustratorBuilder : ABuilder
    {
        Project project = new Project();

        public override void TouBiao()
        {
            project.AddItem("插画师投标！");
        }

        public override void ZhongBiao()
        {
            project.AddItem("插画师中标！");
        }

        public override void SheJi()
        {
            project.AddItem("插画师设计！");
        }

        public override void KaiFa()
        {
            project.AddItem("发那科开发！");
        }

        public override void ShangXian()
        {
            project.AddItem("插画师上线！");
        }

        public override Project ShowProject()
        {
            return project;
        }
    }
}
