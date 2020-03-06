using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    abstract class Bike
    {
        abstract public void showbikeprop(string model,string name);
       
    }
    interface DispalyDetails
    {
        void display();
    }
    class Multiple_inheritance:Bike,DispalyDetails
    {
        public override void showbikeprop(string model, string name)
        {

            Console.WriteLine("{0} {1}", model, name);
        }
        public void display()
        {
            Console.WriteLine("The interface method is defined");
        }
        /*public static void Main(string[] args)
        {
            Multiple_inheritance m = new Multiple_inheritance();
            m.showbikeprop("12g0","passion pro");
            m.display();
        }*/
    }
}
