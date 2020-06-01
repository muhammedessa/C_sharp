using System;
using System.Collections.Generic;

namespace Collections_Queue1
{
    class Program
    {
        static void Main(string[] args)
        {

            Queue<string> names = new Queue<string>();
            names.Enqueue("Muhammed");
            names.Enqueue("Essa");
            names.Enqueue("Khalid");
            names.Enqueue("Walid");
            names.Enqueue("Ali");

            foreach(var x in names)
            {
                Console.WriteLine("names: " + x );
            }

            Console.WriteLine("-------------------- " );
            Console.WriteLine("Dequeue: " + names.Peek());
            Console.WriteLine("Dequeue: " + names.Dequeue());
            Console.WriteLine("-------------------- ");
            foreach (var x in names)
            {
                Console.WriteLine("names: " + x);
            }
            Console.WriteLine("-------------------- ");
            Console.WriteLine("Dequeue: " + names.Peek());
            Console.WriteLine("Dequeue: " + names.Dequeue());
            Console.WriteLine("-------------------- ");
            foreach (var x in names)
            {
                Console.WriteLine("names: " + x);
            }
        }
    }
}
