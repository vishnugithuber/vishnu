using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace handson23
{
    internal class ps2
    {
        public static int add(int a, int b)
        {
            return (a + b);
        }

        public static void Main()
        {
            int a, b;
            int sum;

            Console.Write("Enter first number= ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second number= ");
            b = Convert.ToInt32(Console.ReadLine());

            sum = add(a, b);

            Console.WriteLine("Sum = " + sum);
            Console.ReadLine();
        }
    }
}
