using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library;

namespace HandsonSep6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            person p;
            p = new employees();
            p.work();
            p = new manager();
            p.work();
            p = new clerk();
            p.work();    
            Console.WriteLine(" ");
            bank b1 = new bank();
            b1.print_balance();
            b1.calculate_interest();     
            Console.WriteLine("savings account");
            banks b = new saving();
            b.print_balance();
            b.calc_interest();
            Console.WriteLine("current account");
            banks b2 = new current();
            b2.print_balance();
            b2.calc_interest();      
            Console.WriteLine(" ");
            Bankss BB = new Bankss();
            BB.current();
            BB.savings();
            BB.deposits();
            BB.withdraw();
            BB.total_balc();
            BB.deposits1();
            BB.withdraw1();
            BB.total_balc1();            
        }
    }
}
