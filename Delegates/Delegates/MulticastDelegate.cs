using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public delegate int MyCalc(int x, int y);
    class MulticastDelegate
    {
        public  int myadd(int x,int y)
        {
            return x + y;
        }
        public int mysub(int x,int y)
        {
            return x - y;
        }
        /*static void Main(string[] args)
        {
            MulticastDelegate m = new MulticastDelegate();
            MyCalc c = m.myadd;
            MyCalc c1 = m.mysub;
            int a = c(10, 20);
            int b = c1(10, 20);
            Console.WriteLine("sum=" + a);
            Console.WriteLine("sub=" + b);
        }*/
    }

}
