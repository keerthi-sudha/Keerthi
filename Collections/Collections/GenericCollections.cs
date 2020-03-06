using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Course
    {
        public int cid { get; set; }
        public string cname { get; set; }
        public double fees { get; set; }
        public DateTime startdate { get; set; }
    }
    class GenericCollections
    {
        /*static void Main(string[] args)
        {
            //genericlist();
            /*HashSet<Course> hset = new HashSet<Course>();
            hset.Add(new Course
            {
                cname = "Python",
                cid = 12,
                startdate = Convert.ToDateTime("03-02-2020"),
                fees = 7650
            });
            hset.Add(new Course
            {
                cid = 134,
                cname = "javascript",
                fees = 4500,
                startdate = DateTime.Today
            });
            foreach (Course h in hset)
            {
                Console.WriteLine("{0}\t{1}\t{2}\t{3}", h.cid, h.cname, h.startdate, h.fees);
            }*/
            /*Dictionary<int, Course> dict = new Dictionary<int, Course>();
            dict.Add(1,new Course
            {
                cid = 56,
                cname = "robotics",
                fees = 760,
                startdate = Convert.ToDateTime("09-09-2020")
            });
            dict.Add(2, new Course
            {
                cid = 565,
                cname = "machine learning",
                fees = 7600,
                startdate = Convert.ToDateTime("24-09-2020")
            });
            foreach(KeyValuePair<int,Course> c in dict)
            {
                Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}", c.Key, c.Value.cid, c.Value.cname, c.Value.startdate, c.Value.fees);
            }
            /*SortedDictionary<int, string> sortd = new SortedDictionary<int, string>();
            sortd.Add(123, "Chennai");
            sortd.Add(213, "Hderabad");
            sortd.Add(444, "Vijayawada");
            foreach(KeyValuePair<int,string> ct in sortd)
            {
                Console.WriteLine("{0}\t{1}", ct.Key, ct.Value);
            }*/
        
        /*private static void genericlist()
        {
            List<Course> cl = new List<Course>();
            cl.Add(new Course
            {
                cid = 1,
                cname = "c#",
                startdate = DateTime.Today,
                fees = 8000
            });
            cl.Add(new Course
            {
                cid = 2,
                cname = "Html",
                startdate = Convert.ToDateTime("08-02-2020"),
                fees = 6000
            });
            foreach (Course cr in cl)
            {
                Console.WriteLine("{0}\t{1}\t{2}\t{3}", cr.cid, cr.cname, cr.startdate, cr.fees);
            }
        }*/


    }

}

