using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aug24
{
    internal class ps1
    {
        static void Main(string[] args)
        {
            string s1, s2;
            Console.WriteLine("enter the first string");
            s1 = Console.ReadLine();
            Console.WriteLine("enter the second string");
            s2 = Console.ReadLine();
            if (s1 == s2)
                Console.WriteLine("strings are equal");
            else
                Console.WriteLine("strings are  not equal");
            Console.ReadLine();
        }
    }
}
