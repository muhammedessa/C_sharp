using System;

namespace Muhammed
{
    class Person
    {
        public string fullname = "Muhammed Essa";
        protected int age = 36;

        protected void PrintAge(int age)
        {
            Console.WriteLine("your age is  " + age  );
        }
        public void PrintInfo(string lastname)
        {
            Console.WriteLine("Hello  " + fullname +" "+lastname);
        }
    }
}


namespace ConsoleAppAccessModifier
{

    class Student
    {
        public string fullname = "Muhammed Essa";
        protected int age = 36;

        protected void PrintAge(int age)
        {
            Console.WriteLine("your age is  " + age);
        }
        public void PrintInfo(string lastname)
        {
            Console.WriteLine("Hello  " + fullname + " " + lastname);
        }
    }
    class Program:Student
    {


        private int myage = 12;

        private void myPrintAge(int age)
        {
            Console.WriteLine("your age is  " + age);
        }

        static void Main(string[] args)
        {
            //Muhammed.Person  per = new Muhammed.Person();
            //Console.WriteLine("Hello  " + per.fullname);
            //per.PrintInfo("Hameed");


            //Program stu = new Program();
            //Console.WriteLine("Hello  " + stu.age);
            //stu.PrintAge(22);

            Program prog = new Program();
            Console.WriteLine("Hello  " + prog.myage);
            prog.myPrintAge(25);
        }
    }
}
