using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileOperation
{
    class Class1<T>
    {
        private T[] arr = new T[100];
        public T this[int i]
        {
            get
            {
                return arr[i];
            }
            set
            {
                arr[i] = value;
            }
        }
        static void Indxrdemo()
        {
            var s = new Class1<string>();
            s[0] = "This is indexer demo";
            var std = new Class1<Student>();
            std[0] = new Student
            {
                id = 1,
                studentname = "keerthi",

                course = "c#"
            };
            std[1] = new Student
            {
                id = 2,

                studentname = "sameera",
                course = "web apps"
            };
            Console.WriteLine("{0}\t{1}\t{2}", std[0].id, std[0].studentname, std[0].course);
            Console.WriteLine("{0}\t{1}\t{2}", std[1].id, std[1].studentname, std[1].course);
        }

        public static void Main(string[] args)
        {
            Indxrdemo();
        }

    }

            class Student
            {
                public int id
                {
                    get; set;
                }
                public string studentname
                {
                    get; set;
                }
                public string course
                {
                    get; set;
                }
                    
            }
}
