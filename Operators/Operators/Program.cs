using System;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {

            double num1 = 10;
            double num2 = 5;

            double sum = num1 + num2;

            Console.WriteLine("Add= " + sum);
            Console.WriteLine("Sub= "+  (num1 - num2)  );
            Console.WriteLine("Multi= " + (num1 * num2));
            Console.WriteLine("Div= "+ (num1 / num2));
            Console.WriteLine("Mod= "+ (num1 % num2));
        }
    }
}
