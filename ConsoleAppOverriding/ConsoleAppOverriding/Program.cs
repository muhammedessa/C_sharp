using System;

namespace ConsoleAppOverriding
{

    class Person
    {
        public virtual void eating()
        {
            Console.WriteLine("eating...!");
        }
    }

    class Student:Person
    {
        public override void eating()
        {
            Console.WriteLine("Student is eating...!");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student stu = new Student();
            stu.eating();
        }
    }
}
