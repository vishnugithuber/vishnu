using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assign
{
    internal class assign5
    {
        static void Main(string[] args)
        {
            int num1 = 50;
            int num2 = 90;
            int max;
            Console.WriteLine("Number 1: " + num1);
            Console.WriteLine("Number 2: " + num2);
            if (num1 > num2)
            {
                max = num1;
            }
            else
            {
                max = num2;
            }
            Console.WriteLine("Maximum number is: " + max);
            Console.ReadLine();
        }
    }
}
