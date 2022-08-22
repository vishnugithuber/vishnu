using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment3
{
    internal class assignment12
    {
        static void Main(string[] args)
        {
            double fahr;

            double cel = 38;
            Console.WriteLine("celsius " + cel);

            fahr = (cel * 9) / 5 + 32;
            Console.WriteLine("fahrenheit: " + fahr);

            Console.ReadLine();
        }
    }
}
