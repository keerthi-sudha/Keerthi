using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileOperation
{
    public static class Myextclass
    {
        public static int wordcount(this string str)
        {
            return str.Split(new char[] { ' ', ',', '?' }, StringSplitOptions.RemoveEmptyEntries).Length;
        }
        private static void ExtensionDemo()
        {
            Console.WriteLine("Enter a string");
            string s = Console.ReadLine();
            int i = s.wordcount();
            Console.WriteLine("Number of words:{0}", i);
        }
        /*static void Main(string[] args)
        {
            ExtensionDemo();
        }*/
    }
}
