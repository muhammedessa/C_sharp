using System;
using System.Collections.Generic;

namespace Collections_Dictionary1
{
    class Program
    {
        static void Main(string[] args)
        {
      Dictionary<string, string> names = new Dictionary<string, string>();
            names.Add("1", "Muhammed");
            names.Add("2", "Essa");
            names.Add("3", "Hameed");
            names.Add("4", "Samir");

            foreach (KeyValuePair<string,string> x in names)
            {
             Console.WriteLine("Key: " + x.Key + " " + "Value: " + x.Value);
            }

           
        }
    }
}
