using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment3
{
    internal class assignment16
    {
        static void Main(string[] args)
        {
            string s = "Hello";
            String emplynm = "";
            int deptnum = 0;
            string name = String.Empty;
            Console.WriteLine("Enter the name");
            name = Console.ReadLine();
            if (!string.IsNullOrEmpty(name))
            {
                string greet = string.Concat(s, name);
                Console.Write(greet);
                Console.WriteLine("enter the deptnum");
                deptnum = Convert.ToInt32(Console.ReadLine());
                if (deptnum != 0 && (deptnum >= 1 || deptnum < 10))
                {
                    Console.WriteLine("thanks for input");
                    for (int i = 0; i < 5; i++)
                    {
                        Console.WriteLine("Enter the employee name");
                        emplynm = Console.ReadLine();
                        Console.WriteLine("enter his designation");
                        Console.ReadLine();
                    }
                }
                else
                {
                    Console.WriteLine("enter the valid deptnum");
                }
            }
        }
    }
}
