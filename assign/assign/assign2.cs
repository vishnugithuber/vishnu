﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assign
{
    internal class assign2
    {
        static void Main(string[] args)
        {
            string str1;
            string str2;
            Console.Write("Enter a string1 ");
            str1 = Console.ReadLine();
            Console.Write("Enter a string2: ");
            str2 = Console.ReadLine(); 
            if (str1 == str2)
                Console.WriteLine("\"{0}\" and \"{1}\" are equal", str1, str2);
            else
                Console.WriteLine("\"{0}\" and \"{1}\" are not equal", str1, str2);

            Console.ReadLine();
        }
    }
}
