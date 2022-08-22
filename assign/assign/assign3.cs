using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assign
{
    internal class assign3
    {
        static void Main(string[] args)
        {
            char ch1;
            char ch2;
            Console.Write("Enter ur character ");
            ch1 = Console.ReadLine()[0];
            Console.Write("Enter another charchter ");
            ch2 = Console.ReadLine()[0];
            if (ch1 == ch2)
                Console.WriteLine("given characters are the same");
            else
                Console.WriteLine("given characters are not the same");
            Console.ReadLine();
        }
    }
}
