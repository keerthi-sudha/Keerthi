using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    interface Iairborne 
    {
        void fly();
    }
    class Helicopter:Iairborne
    {
        public void fly()
        {
            Console.WriteLine("This class implements the interface method fly()");
        }
    }
    class Aeroplane:Iairborne
    {
       public void fly()
        {
            Console.WriteLine("Two classes inherited same interface");
        }
    }
    class Interface
    {
       /* public static void Main(string[] args)
        {
            Helicopter h = new Helicopter();
                h.fly();
            Aeroplane a = new Aeroplane();
            a.fly();
        }*/
    }
}
