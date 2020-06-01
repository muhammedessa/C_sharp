using System;

namespace InputUser
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your first name:" );

            string firstName =  Console.ReadLine();
            Console.WriteLine("Your first name is: " + firstName);
        }
    }
}
