using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HandsonSep5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book(1, "Sita", 200, "Amith");
            book.Display();
            Book b2 = new Book();
            b2.InsertBook(2, "Alchemist", 150);
            b2.Display();
            Book b3 = new Book();
            b3.InsertBook(3, "Rama Add", 100, "This product");
            b3.Display();
            Book b4 = new Book();
            b4.InsertBook(4, "Room 105");
            b4.Display();
            Bookcategory b1 = new Bookcategory(1, "Drama", "Gener");
            b1.Display();
            Novels n1 = new Novels();
            n1.InsertBook(1, "Rich dad and poor dad", 500);
            n1.Display();
            Novels n2 = new Novels();
            n2.InsertBook(2, "Ikigai", 200, "Japanese");
            n2.Display();
            Cart c1 = new Cart();
            c1.CustomerId = 44;
            c1.BookingId = 10;
            c1.Addtocart(1, "Rich dad and poor dad", 500);
            c1.Addtocart(2, "psycology of money", 600);
            c1.dis();
            c1.bookdis();
            Cart c2 = new Cart();
            c2.CustomerId = 45;
            c2.BookingId = 50;
            c2.Addtocart(1, "Nari", 200);
            c2.Addtocart(2, "Every one has a story", 180);
            c2.dis();
            c2.bookdis();
            Console.ReadLine();
        }
    }
}
