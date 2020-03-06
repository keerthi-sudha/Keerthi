using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{

    class Events
    {
        public delegate void Deleventhandler();
        public static event Deleventhandler handler;
        static void Main(string[] args)
        {
            handler += new Deleventhandler(Square);
            handler += new Deleventhandler(Circle);
            handler.Invoke();
        }
        static void Circle()
        {
            double r = 12.4;
            double ar = Math.PI * r * r;
            Console.WriteLine("Area of circle:{0}", ar);
        }
        static void Square()
        {
            Double a = 12;
            double area = a * a;
            Console.WriteLine("Area of square:{0}", area);
        }
    }
}
