using System;

namespace ConsoleAppSealed
{

   sealed class Person
    {
        public void walk()
        {
            Console.WriteLine("walk!");
        }
    }

    class Student : Person
    {
        public void smile()
        
        {
            Console.WriteLine("smile!");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student stu = new Student();
            stu.smile();
            stu.walk();
        }
    }
}
