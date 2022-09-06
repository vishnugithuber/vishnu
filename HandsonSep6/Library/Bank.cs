using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
            public interface transaction
            {

                void print_balance();
                void calculate_interest();
            }
            public class bank : transaction
            {

                public double amount;

                public bank()
                {

                    amount = 0;
                }

                public void print_balance()
                {
                    Console.WriteLine("Enter  Amount");
                    amount = Convert.ToDouble(Console.ReadLine());
                }
                public void calculate_interest()
                {
                    int r;
                    Console.WriteLine("enter the interest to calculate");
                    r = Convert.ToInt32(Console.ReadLine());
                    double result = amount * r;
                    Console.WriteLine("calculateinterest " + result);
                }
            } 
}
