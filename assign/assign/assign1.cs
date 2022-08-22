using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assign
{
    internal class assign1
    {
        static void Main(string[] args)
        {
            int i, j, minimum, maximum;

            Console.Write("input first number = ");
            i = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number = ");
            j = Convert.ToInt32(Console.ReadLine());


            if (i > j)
            {
                maximum = i;
            }
            else
            {
                maximum = j;
            }


            if (i < j)
            {
                minimum  = i;
            }

            else
            {
                minimum = j;
            }

            Console.WriteLine("Minimum number = {0}", minimum);
            Console.WriteLine("Maximum number = {0}", maximum);


            Console.ReadLine();
        }
    }
}
