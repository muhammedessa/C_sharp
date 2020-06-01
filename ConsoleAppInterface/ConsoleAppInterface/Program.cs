using System;

namespace ConsoleAppInterface
{

    interface Person
    {
        void fullName();
    }

    interface Person2
    {
        void age();
    }

    class Student : Person, Person2
    {
       public void fullName()
        {
            Console.WriteLine("Student full name!");
        }
        public void age()
        {
            Console.WriteLine("Student age!");
        }
    }

    class Employee : Person
    {
        public void fullName()
        {
            Console.WriteLine("Employee full name!");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person per;
            Student stu = new Student();
            stu.fullName();
            stu.age();

            per = new Employee();
            per.fullName();
        }
    }
}
