using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment3
{
    internal class assignment8
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the amount of Celsius: ");
            int cel= Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Kel = {0}", cel + 273);
            Console.WriteLine("fahr = {0}", cel * 18 / 10 + 32);
            Console.ReadLine();
        }
    }
}
