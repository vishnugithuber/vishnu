using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class array7
    {
        static void Main(string[] args)
        {
            Queue myque = new Queue();
            myque.Enqueue(1);
            myque.Enqueue(2);
            myque.Enqueue(3);
            myque.Enqueue(4);
            myque.Enqueue(5);
            Console.WriteLine("the total no of elemens in the myque are;" + myque.Count);
            Console.WriteLine(" the top element in the top of the queue " + myque.Peek());
            Console.WriteLine(" the top element in the top of the queue " + myque.Dequeue());
            Console.WriteLine("after dequeue the count of myqueue:" + myque.Count);
            Console.ReadLine();


        }
    }
}
