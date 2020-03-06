using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileOperation
{
    class lambda
    {
        private static void Lambdaexpression()
        {
            Func<int,int> cube = a => a * a * a;
            Console.WriteLine("Enter a number");
            int cr = int.Parse(Console.ReadLine());
            Console.WriteLine(cube(cr));

        }
        private static void LambdaLinqOrdr()
        {
            int[] nos = { 65, 89, 32, 4, 21 };
            var sort = nos.OrderBy(x => x);
            Console.WriteLine(string.Join(" ", sort));
        }
        private static void lambdaLinq()
        {
            int[] numbers = { 1, 2, 3, 4 };
               var squ=numbers.Select(x=>x*x);
            Console.WriteLine(string.Join(" ", squ));
        }
        private static void lambdaExp()
        {
            int[] s = { 78, 89, 67, 99, 100, 98 };
                int e = s.Where(n => n >= 85).Count();
            int a = s.Where(x => x >= 75).Count() - e;
            Console.WriteLine(e);
            Console.WriteLine(a);
        }

        private static void Positionalargument(int n,string s)
        {
            Console.WriteLine("{0}\t{1}", n, s);
        }
        public delegate void Mydelg(string s);

        /*public static void Main(string[] args)
        {
            //Lambdaexpression();
            //LambdaLinqOrdr();
            //lambdaLinq();
            //lambdaExp();
            //Positionalargument(5,"keerthi");
            //Mydelg del = a => Console.WriteLine(a);
            //del("hello");
            Func<int, double, double> Calc = (x, y) => x * y;
            Console.WriteLine(Calc(12, 10.5));
            Func<double, double, double> C = (x, y) => ((x * y) / 2);
            Console.WriteLine(C(12, 10));
        }*/
    }
}
