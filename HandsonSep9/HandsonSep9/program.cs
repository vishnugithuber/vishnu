﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HandsonSep9
{
    class Class1
    {
        public static void M1()
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("Method 1 =   {0} ", i);
                if (i == 5)
                {
                    Thread.Sleep(5000);
                }
            }
        }
        public static void M2()
        {
            for (int j = 0; j <= 3; j++)
            {
                Console.WriteLine("Method 2 =   {0} ", j);

            }

        }
        public void M3()
        {
            Console.WriteLine("This  is  M3");
        }

        static void Main(string[] args)
        {
          

            Thread t1 = new Thread(M1);
            Thread t2 = new Thread(M2);






            t1.Start();
            t2.Start();


            Console.Read();

        }
    }
}
    

