using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{

    class Strings
    {
        public static void Main(string[] args)
        {
            string s = "Keerthi";
            Console.WriteLine(s);
            string s1 = s.Insert(7, "sudha");
            string s2 = s.ToLower();
            string s3 = s.ToUpper();
            Console.WriteLine("{0} {1} {2}", s1, s2, s3);
            Console.WriteLine(string.Concat(s, s1));
            Console.WriteLine("substring {0}", s1.Substring(2, 5));
            string[] names = new string[]
            {
                "Anand","Raju","Munna"
            };
            foreach(string st in names)
            {
                Console.WriteLine(st);
            }
            string allnames = string.Join(",", names);
            Console.WriteLine(allnames);
            string st1 = "welcome to the world of C#";
            string[] words = st1.Split();
            foreach(string str in words)
            {
                Console.WriteLine(str);
            }
            string nstr = string.Copy(st1);
            Console.WriteLine("Copied string is {0}", nstr);
            int i = st1.IndexOf("to");
            Console.WriteLine(i);
            int l = st1.Length;
            Console.WriteLine(l);
          Array.Reverse(words);
            foreach(string j in words)
            {
                Console.WriteLine(j);
            }
            int nx = string.Compare("hello", "hello");
            Console.WriteLine("Comparison of strings is {0}",nx);
        }
    }
}


