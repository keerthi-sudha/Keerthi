using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Threads
{
    class Class1
    {
        public static void Main(string[] args)
        {
           /*ist<Course> clst = new List<Course>()
        {
            new Course{cid=1,cname="c#",fees=7000,startdate=Convert.ToDateTime("10-02-2020")},
            new Course{cid=2,cname="css",fees=4000,startdate=Convert.ToDateTime("12-02-2020")},
            new Course{cid=3,cname="ADO.NET",fees=6000,startdate=Convert.ToDateTime("08-02-2020")},
            new Course{cid=4,cname="ASP.NET",fees=8000,startdate=Convert.ToDateTime("06-02-2020")},
        };
            var qget = from a in clst
                       orderby a.fees
                       select a;
            foreach (var q in qget)
            {
                Console.WriteLine("{0}\t{1}\t{2}\t{3}", q.cid, q.cname, q.startdate.ToShortDateString(), q.fees);
            }
            string[] names = { "Ashish", "Amit", "vivek", "Sonali" };
            var shortName = from name in names
                            where name.StartsWith("A")
                            select name;
            foreach (string sname in shortName)
                Console.WriteLine("ShortName:{0}", sname);

            Action<int, int> Multiply = (x, y) => Console.WriteLine("{0}", x * y);

            Multiply(10, 20);
            Func<int, int, double> ad = (x, y) => x + y;
            Console.WriteLine(ad(10, 20));
            Predicate<Course> c = x => x.cid == 3;
            var c1 = clst.Find(c);
            Console.WriteLine("{0}\t{1}\t{2}", c1.cid, c1.cname, c1.fees);*/

            Console.WriteLine("H" + 'i');
        }
    }
        class Course
        {
            public int cid
            {
                get; set;
            }
            public string cname
            {
                get; set;
            }
            public int fees
            {
                get; set;
            }
            public DateTime startdate
            {
                get; set;
            }
        }
}
