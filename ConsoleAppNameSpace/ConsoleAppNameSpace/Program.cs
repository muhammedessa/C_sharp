using System;
using Muhammed;
using Essa;


namespace Muhammed
{
    class Person
    {
        public void PrintInfo()
        {
            Console.WriteLine("namespace Muhammed!");
        }
    }
}

namespace Essa
{
    class Person2
    {
        public void PrintInfo()
        {
            Console.WriteLine("namespace Essa!");
        }
    }
}




namespace ConsoleAppNameSpace
{
    class Program
    {
        static void Main(string[] args)
        {
            //Muhammed.Person mper = new Muhammed.Person();
            //Essa.Person eper = new Essa.Person();

            Person mper = new Person();
            Person2 eper = new  Person2();
            mper.PrintInfo();
           eper.PrintInfo();

        }
    }
}
