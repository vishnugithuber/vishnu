using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assign
{
    internal class assign9
    {
        static void Main(string[] args)
        {
            int i, n, sum = 0;
            Console.Write("enter number ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nThe odd numbers are :");
            for (i = 1; i <= n; i++)
            {
                Console.Write("{0} ", 2 * i - 1);
                sum += 2 * i - 1;
            }
            Console.Write("sum of odd numbers upto {0} terms  {1} \n", n, sum);
            Console.ReadLine();
        }
    }
}
