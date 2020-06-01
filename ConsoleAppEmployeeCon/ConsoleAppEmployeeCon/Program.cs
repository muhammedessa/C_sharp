using System;

namespace ConsoleAppEmployeeCon
{

    class Person
    {

        string name;
        int age;
        string city;
        public Person(string n , int a , string c)
        {
            name = n;
            age = a;
            city = c;
        }
        public void PrintInfo()
        {
       Console.WriteLine("Your name is: " + name +" age: "+ age +" city: "+city);
        }
    }

    class Program
    {


        public Program()
        {
            Console.WriteLine("Hello from constructor!");
        }

        static void Main(string[] args)
        {
            //Program pro = new Program();
            //Program pro2 = new Program();
            //Program pro3 = new Program();

            Person per = new Person("Walid" , 34 , "Baghdad");
            per.PrintInfo();
        }
    }
}
