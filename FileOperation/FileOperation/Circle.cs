using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileOperation
{
    class Circle
    {
        //private double radius;
        //string st;
        /*public double Calculate(Func<double,double>mp)
        {
            return mp(radius);
        }
        public string changecase(Func<string,string>uc)
        {
            return uc(st);
        }
        public void cal()
        {
            Circle c = new Circle();
            Console.WriteLine("Enter radius");
            double p = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(c.Calculate(r => (2 * Math.PI * p)));
           Console.WriteLine();
            Console.WriteLine("enter a string");
            string str = Console.ReadLine();
            Console.WriteLine(c.changecase(a => str.ToUpper()));
            string t = "FROM UPPER CASE TO LOWER CASE";
            Console.WriteLine(c.changecase(x=> t.ToLower()));
        }
       /* public static void Main(string[] args)
        {
            Circle c1 = new Circle();
            c1.cal();
        }*/
    }
}
