﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment3
{
    internal class assignment4
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;

            Console.Write("Enter first number  ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second number ");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter third number - ");
            num3 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Result of specified numbers {0}, {1} and {2}, (x+y)·z is {3} and x·y + y·z is {4}\n\n",
                num1, num2, num3, ((num1 + num2) * num3), (num1 * num2 + num2 * num3));
            Console.ReadLine();
        }
    }
}
