using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Aug25
{
    internal class ps4
    {
         public static void Main(string[] args)
        {
                Console.WriteLine(" E drive info");
                DriveInfo info = new DriveInfo("E");
                Console.WriteLine(info.Name);
                Console.WriteLine(info.TotalSize);
                Console.WriteLine(info.DriveType);
                Console.WriteLine(info.DriveFormat);
                Console.WriteLine("----------------------------");
                DriveInfo[] dinfo = DriveInfo.GetDrives();
                foreach (var item in dinfo)
                {
                    Console.WriteLine(item.Name);
            }
                Console.ReadLine();
            }

        }
    }

