using System;

namespace SwitchCase
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
         

            string myColor = Console.ReadLine();

            switch (myColor)
            {
                case "red" :
                    Console.WriteLine("red");
                break;
                case "blue":
                    Console.WriteLine("blue");
                    break;
                case "orange":
                    Console.WriteLine("orange");
                    break;
                case "yellow":
                    Console.WriteLine("yellow");
                    break;
                default:
                    Console.WriteLine("no color");
                    break;
            }
        }
    }
}
