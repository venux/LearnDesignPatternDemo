using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternLib._3行为型._09访问者模式
{
    public abstract class AVistor
    {
        public abstract void VisitNode1(ANode node1);

        public abstract void VisitNode2(ANode node2);

        public abstract void VisitNode3(ANode node3);
    }
}
