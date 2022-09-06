using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    
        public interface banks
        {

            void print_balance();
            void calc_interest();
        }
        public class saving : banks
        {

            public double amount;

            public saving()
            {

                amount = 0;
            }

            public void print_balance()
            {
                Console.WriteLine("Enter Amount");
                amount = Convert.ToDouble(Console.ReadLine());
            }
            public void calc_interest()
            {
                float r = 0.04f;

                double result = amount * r;
                Console.WriteLine("calc_interest " + result);
            }
        }
        public class current : banks
        {

            public double amount;

            public current()
            {

                amount = 0;
            }

            public void print_balance()
            {
                Console.WriteLine("Enter Amount");
                amount = Convert.ToDouble(Console.ReadLine());
            }
            public void calc_interest()
            {
                float r = 0.02f;

                double result = amount * r;
                Console.WriteLine("calc_interest " + result);
            }
        }   
}
