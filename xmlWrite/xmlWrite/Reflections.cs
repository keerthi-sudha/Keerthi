using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace xmlWrite
{
    class Reflection
    {
        static void Main(string[] args)
        {
            /*Assembly inf = typeof(int).Assembly;
            //Console.WriteLine(inf);
            int x = 10;
            Type t = x.GetType();
            //Console.WriteLine(t);
            //Console.WriteLine(x.GetTypeCode());
            //Console.WriteLine(x.GetHashCode());
            StringBuilder stb = new StringBuilder("Hello");
            //Console.WriteLine(stb.GetType());
            inf = typeof(string).Assembly;
            Console.WriteLine(inf);*/

            Type t = Type.GetType("xmlWrite.Reflection",false,true);
            Console.WriteLine(t.FullName);
           
          }
    }
}
