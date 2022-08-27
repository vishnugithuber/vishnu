using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HandsonAug26;
using static HandsonAug26.ps2class;

namespace HandsonAug26
{
    internal class ps2
    {
        static void Main(string[] args)
        {
            
            Class_stud[] s = new Class_stud[1];
            for (int i = 0; i < s.Length; i++)
            {
            
                s[i] = new Class_stud();

                Console.WriteLine("Enter id:");
                s[i].Id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Name:");
                s[i].SName = Console.ReadLine();
                Console.WriteLine("Enter Age:");
                s[i].age = Convert.ToInt32(Console.ReadLine());
            }
            foreach (var item in s)
            {
                Console.WriteLine("Following are the details");
                Console.WriteLine(item.Id);
                Console.WriteLine(item.SName);
                Console.WriteLine(item.age);
                Console.ReadLine();

            }

        }
    }
}
