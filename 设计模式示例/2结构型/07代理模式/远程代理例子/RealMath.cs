using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternLib._2结构型._07代理模式.远程代理例子
{
    public class RealMath : MarshalByRefObject, IMath
    {
        public double Add(double x, double y)
        {
            return x + y;
        }

        public double Div(double x, double y)
        {
            return x - y;
        }

        public double Mul(double x, double y)
        {
            return x * y;
        }

        public double Sub(double x, double y)
        {
            if (y == 0)
                return double.MaxValue;
            else
                return x / y;
        }
    }
}
