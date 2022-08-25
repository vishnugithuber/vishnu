using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aug25
{
    internal class ps1
    {
        static void Main(string[] args)
        {

            string path = @"E:\NET\Aug25\Aug25";
            Console.WriteLine("Enter the file name");
            string fname = Console.ReadLine();


            fname = string.Concat(path, fname);

            FileStream fs = new FileStream(fname, FileMode.Append);
            StreamWriter sw = new StreamWriter(fs);

            sw.WriteLine("this is from append method");
            sw.Close();
            fs.Close();
            Console.WriteLine(" appended  successfully");
            Console.WriteLine("-----------------------");
            FileStream fs1 = new FileStream(fname, FileMode.Truncate);
            StreamWriter ss1 = new StreamWriter(fs1);

            ss1.WriteLine("heyy hiii ");
            ss1.Close();
            fs1.Close();
            Console.WriteLine(" Truncated  successfully");

            Console.ReadLine();
        }
    }
}
