using System;

namespace ConditionStateIF
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write somthing: ");
            string firstname = Console.ReadLine();

            if(firstname.Equals("Muhammed" , StringComparison.OrdinalIgnoreCase) )
            {
                Console.WriteLine("Hello Muhammed!");
            }
            else if (firstname.Equals("Ahmed", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Hello Ahmed!");
            }
            else
            {
                Console.WriteLine("Not same");
            }

            
        }
    }
}
