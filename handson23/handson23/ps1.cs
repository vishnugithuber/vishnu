using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace handson23
{
    internal class ps1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter first number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter second number");
            int num2 = Convert.ToInt32(Console.ReadLine());
            add(num1, num2);
            Console.ReadLine();

        }
        
        static void add(int a, int b)
        {
            int sum = a + b;
            Console.WriteLine("sum =" + sum);
        }
        
    }
}
