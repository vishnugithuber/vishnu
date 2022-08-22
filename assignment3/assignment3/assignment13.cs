using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment3
{
    internal class assignment13
    {
        static void Main(string[] args)
        {
            double dollar = 0;
            double revenue = 0;
            double value = 0;

            Console.Write("Enter amount in dollars ");
            dollar = double.Parse(Console.ReadLine());

            Console.Write("Enter the dollar value");
            value = double.Parse(Console.ReadLine());

            revenue = dollar * value;
            Console.WriteLine("dollar " + dollar + "revenue " + revenue);
            Console.ReadLine();
           
        }
    }
}
