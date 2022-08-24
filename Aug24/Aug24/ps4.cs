using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aug24
{
    internal class ps4
    {
        static void Main(string[] args)
        {
            string newStr = "heyyy welcome to vs happy learning";
            string[] sep = { "w", "," };

            int count = 2;
            string[] result = newStr.Split(sep, count, StringSplitOptions.RemoveEmptyEntries);
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
