using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Aug25
{
    internal class ps2
    {
        static void Main(string[] args)
        { 
        Console.WriteLine("Enter the file name to be created: ");
           string name = Console.ReadLine();

        string path = @"E:\\NET\\Aug25\\Aug25";

       string filename = String.Concat(path, name);
        File.Create(filename);
           string s = "hi";
       // File.WriteAllText(filename, s);
           // Console.WriteLine("---file copy---");
            //File.Copy(filename, "hi raj.txt");
            //Console.WriteLine("----file moved---");
            //File.Move(filename,"movedfile.txt");
            //Console.WriteLine("---file deleted---");
            //File.Delete(path);
            FileInfo fileInfo = new FileInfo(filename);
        Console.WriteLine(fileInfo.FullName + "  Full Name");
             Console.WriteLine(fileInfo.DirectoryName + " DirectoryName");
            //Console.WriteLine(fileInfo.CreationTime);
            //Directory.CreateDirectory("MyDir");
            Console.ReadLine();

        }
}
}
