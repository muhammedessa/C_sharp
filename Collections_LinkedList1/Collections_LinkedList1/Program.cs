using System;
using System.Collections.Generic;
namespace Collections_LinkedList1
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = new LinkedList<string>();
            names.AddLast("Muhammed");
            names.AddLast("Essa");
            names.AddLast("Hameed");
            names.AddLast("Samir");
            names.AddLast("Ali");
            names.AddFirst("Omer");

            foreach(var x in names)
            {
                Console.WriteLine("names: "+ x);
            }
            Console.WriteLine("------------------- "  );
            LinkedListNode<string> secondNames = names.Find("Samir");
            names.AddBefore(secondNames , "Khalid");
            names.AddAfter(secondNames, "Waleed");
           
            foreach (var x in names)
            {
                Console.WriteLine("names: " + x);
            }

        }
    }
}
