using System;
using System.Collections.Generic;

namespace Collections_Stack1
{
    class Program
    {
        static void Main(string[] args)
        {

            Stack<string> names = new Stack<string>();
            names.Push("Muhammed");
            names.Push("Essa");
            names.Push("Omer");
            names.Push("Ahmed");
            names.Push("Faisal");

            foreach(var x in names)
            {
                Console.WriteLine("names: " + x);
            }
            Console.WriteLine("--------- " );
            Console.WriteLine("peak method: " + names.Peek());
            Console.WriteLine("pop method: " + names.Pop());
            Console.WriteLine("--------- ");
            foreach (var x in names)
            {
                Console.WriteLine("names: " + x);
            }
            Console.WriteLine("--------- ");
            Console.WriteLine("peak method: " + names.Peek());
            Console.WriteLine("pop method: " + names.Pop());
            Console.WriteLine("--------- ");
            foreach (var x in names)
            {
                Console.WriteLine("names: " + x);
            }
        }
    }
}
