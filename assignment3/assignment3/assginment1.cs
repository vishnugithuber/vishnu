using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment3
{
    internal class assginment1
    {
        static void Main(string[] args)
        {
            int a = 6, b = 7;
            Console.WriteLine("Before swapping a= " + a + " b= " + b);
            a = a + b;
            b = a - b;
            a = a - b;
            Console.Write("After swapping a= " + a + " b= " + b);
            Console.ReadLine();
        }
    }
}
