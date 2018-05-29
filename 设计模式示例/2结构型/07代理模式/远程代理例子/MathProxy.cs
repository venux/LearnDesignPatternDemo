using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternLib._2结构型._07代理模式.远程代理例子
{
    public class MathProxy : IMath
    {
        private RealMath math = null;

        public MathProxy()
        {
            AppDomain app = AppDomain.CreateDomain("RealMathApp", null, null);

            //当前应用程序的完整名称，和带命名空间的类名
            ObjectHandle obj = app.CreateInstance(Assembly.GetCallingAssembly().FullName, "DesignPatternLib._2结构型._07代理模式.远程代理例子.RealMath", false, System.Reflection.BindingFlags.CreateInstance, null, null, null, null);
            math = (RealMath)obj.Unwrap();
        }

        public double Add(double x, double y)
        {
            return math.Add(x, y);
        }

        public double Div(double x, double y)
        {
            return math.Div(x, y);
        }

        public double Mul(double x, double y)
        {
            return math.Mul(x, y);
        }

        public double Sub(double x, double y)
        {
            return math.Sub(x, y);
        }
    }
}
