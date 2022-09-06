using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{

    public class Bankss
    {
        public int x, y;
        public Bankss()
        {
            x = 10000;
            y = 20000;
        }


    }
    public static class curr
    {

        public static void current(this Bankss obj)
        {
            Console.WriteLine("current balance " + obj.x);
        }
        public static void deposits(this Bankss obj)
        {
            Console.WriteLine("enter the amount to deposit in your current account");
            int dep = Convert.ToInt32(Console.ReadLine());
            obj.x = dep + obj.x;
            Console.WriteLine("Amount deposited");
        }
        public static void withdraw(this Bankss obj)
        {
            Console.WriteLine("enter the amount to withdraw in current account");
            int with = Convert.ToInt32(Console.ReadLine());
            if (with < obj.x)
                obj.x = obj.x - with;
            else
                Console.WriteLine("amount can't be withdraw");
            Console.WriteLine("Amount Withdrawn");

        }
        public static void total_balc(this Bankss obj)
        {
            Console.WriteLine("total balance in  your current account " + obj.x);
        }
    }
    public static class sav
    {

        public static void savings(this Bankss obj)
        {
            Console.WriteLine("saving balance" + obj.y);
        }
        public static void deposits1(this Bankss obj)
        {
            Console.WriteLine("enter the amount to be  deposited in savings account");
            int dep = Convert.ToInt32(Console.ReadLine());

            obj.y = dep + obj.y;
            Console.WriteLine("Amount Deposited");
        }
        public static void withdraw1(this Bankss obj)
        {
            Console.WriteLine("enter the amount to withdraw in savings accnt");
            int with = Convert.ToInt32(Console.ReadLine());
            if (with < obj.y)
                obj.y = obj.y - with;
            else
                Console.WriteLine("amount can't be withdraw");
            Console.WriteLine("Amount Withdrawn");
        }
        public static void total_balc1(this Bankss obj)
        {
            Console.WriteLine("total balance in your current account " + obj.y);
        }
    }
}
