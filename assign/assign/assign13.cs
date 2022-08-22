using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assign
{
    internal class assign13
    {
        static void Main(string[] args)
        {
            int i;
            Console.WriteLine("Enter the number");
            i = Convert.ToInt32(Console.ReadLine());
            if (i == 0)
                Console.WriteLine("zero");
            else if (i % 2 == 0)
            {
                Console.WriteLine("even");
                if (i % 10 == 0)
                {
                    Console.WriteLine(" it is a multiple of 10");
                }
                else
                {
                    Console.WriteLine(" it is not a multiple of 10");
                }
                if (i > 100)
                    Console.WriteLine("it has more than expected value");
            }
            else
            {
                Console.WriteLine("odd");
                Console.WriteLine(" it is not a multiple of 10");
                if (i > 100)
                    Console.WriteLine(" it has more than exepected value ");
            }
            Console.ReadLine();
        }
    }
}
