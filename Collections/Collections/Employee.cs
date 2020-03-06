using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Employee
    {
        public int eid { get; set; }
        public string ename { get; set; }
        public string desg { get; set; }
        public double sal { get; set; }

    }
    class EmpCollection
    {
        List<Employee> emp = new List<Employee>();
        public void adddata()

        {
            Console.WriteLine("Enter id");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("enter name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter desg");
            string des = Console.ReadLine();
            Console.WriteLine("enter salary");
            double s = double.Parse(Console.ReadLine());
            emp.Add(new Employee
            {
                eid = id,
                ename = name,
                desg = des,
                sal = s
            });
        }

        void display()
        {


            foreach (Employee e in emp)
                Console.WriteLine("{0}\t{1}\t{2}\t{3}", e.eid, e.ename, e.desg, e.sal);
        }
        void remove()
        {
            Console.WriteLine("Enter the index");
            int i = int.Parse(Console.ReadLine());
            emp.RemoveAt(i);
        }
        /*public static void Main(string[] args)
        {
            EmpCollection e = new EmpCollection();
            e.adddata();
            e.adddata();
            e.display();
            e.remove();
            e.display();
        }*/

    }
}
