using System;
using System.Collections.Generic;

namespace Collections_SortedSet1
{
    class Program
    {
        static void Main(string[] args)
        {

            var names = new SortedSet<string>();
            names.Add("Muhammed");
            names.Add("Essa");
            names.Add("Hameed");
            names.Add("Muhammed");

            foreach(var x in names)
            {
                Console.WriteLine("names: " + x);
            }
            var ages = new SortedSet<int>() {22,33,44,55,66,77 };
            foreach (var x in ages)
            {
                Console.WriteLine("ages: " + x);
            }
        }
    }
}
