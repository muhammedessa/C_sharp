using System;

namespace ConsoleAppChecked
{
    class Program
    {
        static void Main(string[] args)
        {

            unchecked
            {
                int num = int.MaxValue;
                int sum = num + 10;

                Console.WriteLine(sum);
            }
        }
    }
}
