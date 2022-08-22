using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class array4
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList() { 5, 6, 7, 3, "welcome" };
            al.Add(7);
            al.Add(8);
            al.Add("vs");
            al.Remove(8);
            al.RemoveAt(0);

            Console.WriteLine("Elements in Arraylist are: ");
            foreach (var item in al)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\nCount is : " + al.Count);
            Console.ReadLine();
        }
    }
}
