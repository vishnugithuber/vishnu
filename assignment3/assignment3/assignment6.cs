using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment3
{
    internal class assignment6
    {
       static void Main(string[] args)
        {
            int num;

            Console.WriteLine("Enter a digit: ");
            num = Convert.ToInt32(Console.ReadLine());
            Console.Write(num);
            Console.Write(num);
          
            Console.Write(num);
            
            Console.Write(num);
            
            Console.Write(num);
            Console.Write(num);
            Console.Write(num);
            Console.WriteLine(num);
            Console.WriteLine();
            Console.WriteLine("{0} {0} {0} {0}", num);

            Console.WriteLine("{0}{0}{0}{0}", num);
            Console.ReadLine();
        }

    }
}
