using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class array9
    {
        static void Main(string[] args)

        {
            List<float> lst = new List<float>();
            float[] areas = new float[] { 9.0f, 45.22f, 56.78f, 45.45f, 5678.33f };


            foreach (var item in areas)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
