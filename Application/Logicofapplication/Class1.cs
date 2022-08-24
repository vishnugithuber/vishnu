using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using static System.Net.Mime.MediaTypeNames;

namespace Logicofapplication
{
    public class Sampleclass
    {
        public static void Greet()
        {
            Console.WriteLine("helloyaar");

        }
        public static void Makefile()
        {
        
            string path = @" E:\NET\Application\firstfile.txt";
            File.Create(path);



        }


    }
}
