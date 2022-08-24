using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aug24
{
    internal class ps7
    {
        static void Main(string[] args)
        {
            DateTime dt1 = new DateTime();
            dt1 = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine("enter your bday date");
            Console.WriteLine("day = " + dt1.Day);
            Console.WriteLine("month = " + dt1.Month);
            Console.WriteLine("year = " + dt1.Year);
            Console.WriteLine("year = " + dt1.DayOfWeek);
            bool isLeapYear = DateTime.IsLeapYear(dt1.Year);
            Console.WriteLine(isLeapYear);
            
            Console.ReadLine();
        }
    }
}
