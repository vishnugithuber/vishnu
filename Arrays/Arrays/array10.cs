﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class array10
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> dict = new Dictionary<int, string>();
            dict.Add(1, "vishnu");
            dict.Add(2, "priya");
            dict.Add(3, "hii");
            Console.WriteLine("Values in Dictionary are: \n");
            foreach (KeyValuePair<int, string> item in dict)
            {
                Console.WriteLine(item.Key + "  " + item.Value);

            }
            Console.ReadKey();
        }
    }
}
