using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsonAug26
{
    internal class ps4
    {
        static void Main(string[] args)
        {
            // LinkedList<int> mylist = new LinkedList<int>();
            LinkedList<string> mylist2 = new LinkedList<string>();
            // mylist.AddFirst(1);
            // mylist.AddLast(2);
            //mylist.AddAfter(mylist.First, 3);
            //mylist.AddBefore(mylist.Last, 4);
            mylist2.AddFirst("vishnu");
            mylist2.AddLast("priya");
            mylist2.AddAfter(mylist2.First, "mounika");
            mylist2.AddBefore(mylist2.Last, "hii there");
            mylist2.AddBefore(mylist2.Last.Previous, "welcome");
            mylist2.AddAfter(mylist2.First.Next, "syring");

            //  foreach (var item in mylist)
            {
                // Console.WriteLine(item);
            }
            foreach (var item in mylist2)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
