using System;

namespace ConsoleAppEncapsulation
{

    class Employee
    {
        public string name { get; set; } 
        public int age { get; set; }
        public float salary { get; set; }
        public string department { get; set; }
    }

    class Program
    { 
        static void Main(string[] args)
        {

            Employee emp = new Employee();
            emp.name = "Muhammed Essa";
            emp.age = 36;
            emp.salary = 234.564f;
            emp.department = "C# developer";

            Console.WriteLine("name: " + emp.name);
            Console.WriteLine("age: " + emp.age);
            Console.WriteLine("salary: " + emp.salary);
            Console.WriteLine("department: " + emp.department);
        }
    }
}
