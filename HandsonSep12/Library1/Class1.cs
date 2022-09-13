using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library1
{
    public class Class1
    {
        public double number
        {
            get;
            set;
        }
        public double Cube1(double number)
        {

            double d = number * number * number;
            return d;
        }
        public double squareroot(double number)
        {
            double dd = Math.Sqrt(number);
            return dd;
        }
    }
}


