using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assign
{
    internal class assign7
    {
        static void Main(string[] args)
        {
            double sub1, sub2, sub3, total, percent;
            string div;

            Console.Write("Enter the marks in first subject1: ");
            sub1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the marks in first subject2: ");
            sub2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the marks in first subject3:");
            sub3 = Convert.ToInt32(Console.ReadLine());

            total = sub1 + sub2 + sub3;
            percent = total / 3.0;
            if (percent >= 60)
                div = "first";
            else
                if (percent < 60 && percent >= 45)
                div = "second";
            else
                    if (percent < 35 && percent >= 45)
                div = "third";
            else
                div = "fail";
            Console.Write("Marks in subject1 : {0} Marks in subject2 : {1} Marks in subject3 : {2} ", sub1, sub2, sub3);
            Console.Write("Total Marks = {0}\nPercentage = {1}\nDivision = {2}\n", total, percent, div);

            Console.ReadLine();

        }
    }
}
