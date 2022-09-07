
using System;
using Library;
using static Library.Class1;

namespace HandsonSep9
{
    internal class Program
    {
        public delegate string ps5(string spo, string spo1);
        static void Main(string[] args)
        {
            Console.WriteLine("-------");
            Console.WriteLine("Enter the string");
            string a = Console.ReadLine();
            str s1 = new str();
            ps1 s2 = new ps1(s1.stringlen);
            s2(a);
            Console.WriteLine("-----");
            Console.WriteLine("Enter username");
            string b = Console.ReadLine();
            ps1 s3 = new ps1(s1.greet);
            s3(b);
            Console.WriteLine("------");
            Console.WriteLine("Enter the two numbers");
            int c = Convert.ToInt32(Console.ReadLine());
            int d = Convert.ToInt32(Console.ReadLine());
            integer e = new integer();
            ps2[] d3 = new ps2[3] { e.Add, e.Sub, e.Multiply };
            ps2 d4 = (ps2)MulticastDelegate.Combine(d3);
            d4(c, d);
            Console.WriteLine("-------");
            Console.WriteLine("Enter productId and product name");
            Products mo = new Products();
            mo.PId = Convert.ToInt32(Console.ReadLine());
            mo.Name = Console.ReadLine();
            ps3 poi = new ps3(mo.Display);
            poi(mo);
            Console.WriteLine("------");
            Console.WriteLine("Enter the year,Month,date");
            int yr = Convert.ToInt32(Console.ReadLine());
            int mon = Convert.ToInt32(Console.ReadLine());
            int dt = Convert.ToInt32(Console.ReadLine());
            Employee emp = new Employee();
            DateTime t = new DateTime(yr, mon, dt);
            emp.Joining = t;
            ps4 se = new ps4(emp.Expyrs);
            int poiu = se(emp.Joining);
            Console.WriteLine($"Years of exp {poiu}");
            Console.WriteLine("------");
            Console.WriteLine("Enter strings to Concatenate");
            string yum = Console.ReadLine();
            string muy = Console.ReadLine();
            ps5 dpo = delegate (string so, string su)
            {
                return so + su;
            };
            string sod = dpo(yum, muy);
            Console.WriteLine($"Concatenated string is {sod}");
            
            Console.ReadLine();
        }
    }
}

