using System;
using System.Collections.Generic;
namespace Collections_HashSet1
{
    class Program
    {
        static void Main(string[] args)
        {

            var names = new HashSet<string>();
            names.Add("Muhammed");
            names.Add("Essa");
            names.Add("Hameed");
            names.Add("Muhammed");

            foreach(var x in names)
            {
                Console.WriteLine("name: " + x);
            }

            var ages = new HashSet<int>() { 22,33,44,55,66,77};
            foreach (var x in ages)
            {
                Console.WriteLine("name: " + x);
            }


        }
    }
}
