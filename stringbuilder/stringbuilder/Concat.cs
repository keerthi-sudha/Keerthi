using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringbuilder
{
    class Concat
    {
        static string concatstrings(string firstname,string lastname)
        {
            string fullname = string.Concat(firstname, lastname);
            return fullname;
            
        }
        /*public static void Main(string[] args)
        {
            string f, l;
            Console.WriteLine("Enter firstname");
            f = Console.ReadLine();
            Console.WriteLine("Enter lastname");
            l = Console.ReadLine();
            string ful = concatstrings(f, l);
            Console.WriteLine(ful);
        }*/
    }
}
