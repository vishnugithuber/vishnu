using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BAL;
using Hidding;

namespace HandsOnSep24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.Add 2.Update 3.Login");
            habook j1 = new habook();

            int m = Convert.ToInt32(Console.ReadLine());
            switch (m)
            {
                case 1:
                    Books b1 = new Books();
                    Console.WriteLine("Enter Book ID");
                    b1.BookId = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Book Name");
                    b1.Bookname = Console.ReadLine();
                    Console.WriteLine("Enter Book author");
                    b1.Author = Console.ReadLine();
                    Console.WriteLine("Enter Book Price");
                    b1.Price = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter Book Category");
                    b1.Ctegory = Console.ReadLine();

                    j1.insert(b1);
                    break;
                case 2:
                    Console.WriteLine("Enter BookNo you want to update");
                    int ji = Convert.ToInt32(Console.ReadLine());

                    j1.Update(ji);
                    break;
                case 3:
                star:
                    Console.WriteLine("Enter Username");
                    int st = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Password");
                    string ts = Console.ReadLine();

                    if (j1.validateuser(st, ts))
                    {
                        List<Books> s11 = new List<Books>();
                        s11 = j1.booli();
                        Console.WriteLine("List of Books");
                        foreach (var item in s11)
                        {
                            Console.Write($"{item.BookId},{item.Bookname},{item.Author},{item.Price},{item.Ctegory}\n");
                        }
                        Console.WriteLine("Do you want to borrow or return");
                        string nt = Console.ReadLine();
                        if (nt.Equals("borrow"))
                        {
                            issued i1 = new issued();
                            Console.WriteLine("Enter issue id");
                            i1.issueid = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("number of the book you want to hire");
                            i1.bkno = Convert.ToInt32(Console.ReadLine());
                            i1.mberid = st;
                            bool po = j1.insertissue(i1);
                            if (po)
                            {
                                Console.WriteLine("inserted issue successfully");
                            }
                            else
                            {
                                Console.WriteLine("Some issues");

                            }



                        }
                        else if (nt.Equals("return"))
                        {
                            issued i2 = new issued();
                            Console.WriteLine("Enter the Library issue id name you want to return");
                            i2.issueid = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter the Book you want to return");
                            i2.bkno = Convert.ToInt32(Console.ReadLine());
                            i2.mberid = st;

                            bool ko = j1.updatestatuses(i2);
                            if (ko)
                            {
                                Console.WriteLine("Updated status successfully");
                            }
                            else
                            {
                                Console.WriteLine("Some mismatches or errors");
                            }
                        }

                    }
                    else
                    {
                        Console.WriteLine("Try again");
                        goto star;
                    }

                    break;
            }
            Console.ReadLine();
        }
    }
}
        
    

