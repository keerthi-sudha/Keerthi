using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringbuilder
{
    class Join
    {
        static void stringarray(string[] a)
        {

            string s = string.Join(" ", a);
            Console.WriteLine(s[0]);
        }
        /*public static void Main(string[] args)
        {
            string[] a1 = { "keerthi", "sameera", "sravya" };
            stringarray(a1);
        }*/
    }
}
