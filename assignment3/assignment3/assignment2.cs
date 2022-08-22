using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment3
{
    internal class assignment2
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;

            Console.Write("enter  first number  ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("enter  second number");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("enter third number  ");
            num3 = Convert.ToInt32(Console.ReadLine());
            int result = num1 * num2 * num3;
            Console.WriteLine("Output {0} x {1} x {2} = {3}",
                                num1, num2, num3, result);
            Console.ReadLine();
        }
    }
}
