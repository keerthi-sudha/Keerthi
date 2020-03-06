using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibCalculation
{
    public class Calculation
    {
        public int No1
        {
            get;set;
        }
        public int No2
        {
            get;set;
        }
        public string Add()
        {
            return string.Format("Sum={0}", No1 + No2);
        }
        public string Difference()
        {
            return string.Format("Difference={0}", No1 - No2);
        }
        public string Multiply()
        {
            return string.Format("Product={0}", No1 * No2);

        }
        public string Division()
        {
            return string.Format("Quotient is {0}", No1 / No2);
        }
    }
}
