using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using BAL;

namespace Hidding
{
    public class habook
    {
        DAbooks k = null;
        public habook()
        {
            k = new DAbooks();
        }
        public void insert(Books b)

        {
            bool r = k.InsertBook(b);
            if (r)
            {
                Console.WriteLine("Inserted successfully");
            }

        }
        public void Update(int num)
        {
            Console.WriteLine("1.UpdateBookNo 2.UpdateBookName 3.UpdateAuthor 4.UpdatePrice 5.UpdateCategory");
            int k1 = Convert.ToInt32(Console.ReadLine());
            switch (k1)
            {
                case 1:
                    bool k2 = k.UpdateBookNo(num);
                    if (k2)
                    {
                        Console.WriteLine("Updated successfully");
                    }
                    break;
                case 2:
                    bool k3 = k.UpdateBookName(num);
                    if (k3)
                    {
                        Console.WriteLine("Updated successfully");
                    }
                    break;
                case 3:
                    bool k4 = k.UpdateBookAuthor(num);
                    if (k4)
                    {
                        Console.WriteLine("Updated successfully");
                    }
                    break;
                case 4:
                    bool k5 = k.UpdateBookPrice(num);
                    if (k5)
                    {
                        Console.WriteLine("Updated successfully");
                    }
                    break;
                case 5:
                    bool k6 = k.UpdateBookCategory(num);
                    if (k6)
                    {
                        Console.WriteLine("Updated successfully");
                    }
                    break;
            }
        }
        public bool validateuser(int tr, string rt)
        {
            return k.validatinguser(tr, rt);
        }
        public List<Books> booli()
        {
            List<Books> s1 = new List<Books>();
            s1 = k.bookli();
            return s1;
        }
        public bool insertissue(issued i1)
        {
            return k.InsertIssue(i1);
        }
        public bool updatestatuses(issued i2)
        {
            return k.updatestatus(i2);
        }
    }
}
