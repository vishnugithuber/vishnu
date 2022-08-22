using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment3
{
    internal class assignment9
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter first number");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter second number");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("is the entered  first number is negative and one other is positive:");
            Console.WriteLine((x < 0 && y > 0) || (x > 0 && y < 0));
            Console.ReadLine();
        }
    }
}
