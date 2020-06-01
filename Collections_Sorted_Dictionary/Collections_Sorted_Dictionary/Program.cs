using System;
using System.Collections.Generic;
namespace Collections_Sorted_Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {

            SortedDictionary<int, string> names = new SortedDictionary<int, string>();
            names.Add(1, "Muhammed");
            names.Add(5, "Essa");
            names.Add(4, "Yousif");
            names.Add(2, "Abbas");
            names.Add(3, "Ali");

            foreach(KeyValuePair<int,string> x in names)
            {
          Console.WriteLine("key: " + x.Key + " " + "Value: " + x.Value);
            }
           
        }
    }
}
