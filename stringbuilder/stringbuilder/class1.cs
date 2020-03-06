using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringbuilder
{
    class class1
    {
       static  int Sum(int[] a)
        {
            int s = 0, i;
            for (i = 0; i < a.Length; i++)
            {
                if (a[i] % 2 == 0)
                {
                    s = s + a[i];
                }
            }
            return s;
        }
       /* public static void Main(string[] args)
        {
            int[] a1 = new int[5];
            Console.WriteLine("Enter the elements of the array");
            for(int i=0;i<5;i++)
            {
                 a1[i]=Convert.ToInt32(Console.ReadLine());
            
            }
          
            int sum = Sum(a1);
            Console.WriteLine(sum);
        }*/
        
    }
}
