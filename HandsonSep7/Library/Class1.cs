using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Library
{
    public class Class1
    {
        public delegate void ps1(string s);
        public delegate void ps2(int i, int j);
        public delegate void ps3(Products p);
        public delegate int ps4(DateTime t);
        public class str
        {
            public void stringlen(string s)
            {
                Console.WriteLine(s.Length);
                string s1 = s.ToUpper();
                Console.WriteLine(s1);


            }
            public void greet(string s)
            {
                Console.WriteLine($"Hello {s}");
            }
        }
        public class integer
        {
            public void Add(int i, int j)
            {
                Console.WriteLine($"Addition 0f {i},{j} is  {i + j}");
            }
            public void Sub(int i, int j)
            {
                if (i > j)
                {
                    Console.WriteLine($"Subtraction of {i},{j} is {i - j}");
                }
                else
                {
                    Console.WriteLine($"Subtraction of {i},{j} is  {j - i}");
                }
            }
            public void Multiply(int i, int j)
            {
                Console.WriteLine($"Multiplication of {i},{j} is  {j * i}");
            }

        }
        public class Products
        {
            public int PId
            {
                get;
                set;
            }
            public string Name
            {
                get;
                set;
            }
            public void Display(Products p)
            {
                Console.WriteLine($"Product id is {p.PId} and name of the product {p.Name}");
            }
        }
        public class Employee
        {
            private DateTime _joining;
            public DateTime Joining
            {
                get { return _joining; }
                set { _joining = value; }

            }
            public int Expyrs(DateTime ji)
            {
                int p = DateTime.Now.Year - ji.Year;
                return p;
            }
        }
    }
}
