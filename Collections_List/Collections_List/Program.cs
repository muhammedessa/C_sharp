using System;
using System.Collections.Generic;

namespace Collections_List1
{
    class Program
    {
        static void Main(string[] args)
        {

            var names = new List<string>();
            names.Add("Muhammed");
            names.Add("Essa");
            names.Add("Hameed");
            names.Add("Muhammed");
 

            var ages = new List<int>() { 33,22,44,55,66 };

            foreach(var x in names)
            {
                Console.WriteLine("names: " + x);
            }
            foreach (var x in ages)
            {
                Console.WriteLine("ages: " + x);
            }


        }
    }
}
