using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class array15
    {
        public static void printFirstRepeating(int[] arr)
        {
         
            int min = -1;

            HashSet<int> set = new HashSet<int>();

           
            for (int i = arr.Length - 1; i >= 0; i--)
            {
               
                if (set.Contains(arr[i]))
                {
                    min = i;
                }

                else 
                {
                    set.Add(arr[i]);
                }
            }
            if (min != -1)
            {
                Console.WriteLine("The first repeating element is " + arr[min]);
            }
            else
            {
                Console.WriteLine("There are no repeating elements");
            }
            Console.ReadLine();
        }

        public static void Main(string[] args)
        {
            int[] arr = new int[] { 10, 5, 3, 4, 3, 5, 6 };
            printFirstRepeating(arr);
        }
    }
}
