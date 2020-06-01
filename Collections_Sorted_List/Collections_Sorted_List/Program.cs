using System;
using System.Collections.Generic;

namespace Collections_Sorted_List
{
    class Program
    {
        static void Main(string[] args)
        {

            SortedList<string, string> names = new SortedList<string, string>();
            names.Add("1","Muhammed");
            names.Add("5", "Essa");
            names.Add("2", "Omer");
            names.Add("4", "laith");
            names.Add("3", "Ali");

            foreach(KeyValuePair<string,string> x in names)
            {
                Console.WriteLine("Key: "+x.Key +" "+ "Value:" + x.Value);
            }

           
        }
    }
}
