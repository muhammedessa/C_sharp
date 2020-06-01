using System;

namespace ConsoleAppAbstraction
{

   abstract class Person
    {
        public abstract void name();
        public abstract void age();
    }

    class Student:Person
    {
        public override void name()
        {
            Console.WriteLine("Muhammed Student!");
        }
        public override void age()
        {
           
        }
    }

    class Employee: Person
    {
        public override void name()
        {
            Console.WriteLine("Muhammed Employee!");
        }
        public override void age()
        {

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person per;
            per = new Student();
            per.name();

            per = new Employee();
            per.name();
        }
    }
}
