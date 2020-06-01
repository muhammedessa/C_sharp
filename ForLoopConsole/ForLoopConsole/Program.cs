using System;

namespace ForLoopConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int x = 1; x < 11; x++) // this is foorloop
            {
               Console.WriteLine("Hello World!" + x );
            }
            // this is arrays of colors
            string[] mycolors = { "red","white","Blue","Yellow","black" };

           for (int x = 0; x < mycolors.Length; x++)
            {
                Console.WriteLine("Hello World!" + mycolors[x]);
            }
        
        }
    }
}
