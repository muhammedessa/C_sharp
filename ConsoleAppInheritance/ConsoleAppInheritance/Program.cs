using System;

namespace ConsoleAppInheritance
{

    class Animal
    {
        public int age = 12;
        public void eating()
        {
            Console.WriteLine("Eating..." );
        }
    }

    class Dog:Animal
    {
        public string name = "Dog";
        public void walk()
        {
            Console.WriteLine("walking...");
        }
    }

    class Cat: Dog
    {
        public void sleep()
        {
            Console.WriteLine("sleep...");
        }
    }




    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat();


            cat.eating();
            cat.walk();
            cat.sleep();



        }
    }
}
