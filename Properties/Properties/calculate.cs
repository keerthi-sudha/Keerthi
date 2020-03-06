using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    class calculate
    {
        public string area(int side)
        {
            int ar = side * side;
            return string.Format("Square area={0}", ar);
        }
        public string area(int l,int b)
        {
            int ar = l * b;
            return string.Format("Rectangle area={0}", ar);
        }
        public string area(double r)
        {
            double ar = Math.PI * r * r;
            return string.Format("Area of circle={0}", ar);
        }
        public string area(double b,int h)
        {
            double ar = 0.5 * b * h;
            return string.Format("Triangle area is {0}", ar);
        }
    }
}
