using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsonAug26
{
    internal class ps3
    {
        static void Main(string[] args)
        {
            List<int> productIDlist = new List<int>();
            List<string>producnamelist = new List<string>();
            productIDlist.Add(1);
            productIDlist.Add(2);
            productIDlist.Add(3);   
            //productIDlist.Add(3);
            producnamelist.Add("caffine");
            producnamelist.Add("wow");
            producnamelist.Add("dherma");
            foreach (var i in productIDlist)
            {
                Console.WriteLine(i);
            }
            foreach(var j in producnamelist)
            {
                Console.WriteLine(j);
            }
            int indexToRemove = 1;
            productIDlist.Remove(indexToRemove);
            foreach(var i in productIDlist)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
