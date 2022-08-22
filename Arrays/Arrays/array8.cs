using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class array8
    {
        static void Main(string[] args)
        {
            Hashtable my_hashtable = new Hashtable();
            my_hashtable.Add("A1", "hii");
            my_hashtable.Add("A2", "to");
            my_hashtable.Add("A3", "hello");
            my_hashtable.Remove("A2");

            Console.WriteLine("Key and Value pairs :");

            foreach (DictionaryEntry ele1 in my_hashtable)
            {
                Console.WriteLine("{0} and {1} ", ele1.Key, ele1.Value);
            }
            Console.WriteLine("Total number of elements present" +
                    " in my_hashtable:{0}", my_hashtable.Count);

            my_hashtable.Clear();
            Console.WriteLine("Total number of elements present in" +
                        " my_hashtable:{0}", my_hashtable.Count);
            Console.ReadLine();


        }

    }

}
