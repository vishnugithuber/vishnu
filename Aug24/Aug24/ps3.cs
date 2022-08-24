using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aug24
{
    internal class ps3
    {
        static void Main(string[] args)
        {

            string str = "vishnupriya";
            int result;
            result = str.IndexOf('i');
            Console.WriteLine("Index of i: " + result);
            result = str.IndexOf('p');
            Console.WriteLine("Index of p: " + result);

            Console.ReadLine();
        }
    }
}
