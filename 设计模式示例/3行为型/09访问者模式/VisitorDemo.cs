using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternLib._3行为型._09访问者模式
{
    public class VisitorDemo
    {
        public static void VisitorDemoTest()
        {
            var nodeStructure = new NodeStructure();

            nodeStructure.Add(new Node1());
            nodeStructure.Add(new Node2());
            nodeStructure.Add(new Node3());

            nodeStructure.Accept(new Vistor1());

            Console.WriteLine("----------------------");

            nodeStructure.Accept(new Vistor2());
        }
    }
}
