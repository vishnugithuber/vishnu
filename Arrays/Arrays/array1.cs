using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class array1
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            int i;
            Console.Write("enter the elements\n");
            for (i = 0; i < 10; i++)
            {
                Console.Write("arr{0} =", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("\nElements in array are: ");
            for (i = 0; i < 10; i++)
            {
                Console.Write("{0}  ", arr[i]);
            }
            Console.Write("\n");
            Console.ReadLine();
        }
    }
}
