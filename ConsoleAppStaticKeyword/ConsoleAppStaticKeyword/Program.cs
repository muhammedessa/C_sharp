using System;

namespace ConsoleAppStaticKeyword
{


      class Employee
    {
        public string name;
        public int age;
        public static string companyName  ;
        public static int counter = 0;

        public Employee(string name , int age  )
        { 
            this.name = name;
            this.age = age;
            counter++;
        }

        static Employee()
        {
            companyName = "Muhammed";
        }


        public void PrintInfo()
        {
            Console.WriteLine("name: "+name + "   age: "+
                age + "  Company Name  " + companyName);
        }
    }




      class Program
    {
  

        static void Main(string[] args)
        {

            Employee em = new Employee("Salim", 35);
            Employee em2 = new Employee("Fahad", 22);
            Employee em3 = new Employee("Taha", 44);
            em.PrintInfo();
            em2.PrintInfo();
            em3.PrintInfo();
        }



    }
}

//Employee.companyName = "Essa";
//Employee em = new Employee("Salim", 35);
//Employee em2 = new Employee("Fahad", 22);
//Employee em3 = new Employee("Taha", 44);
//em.PrintInfo();
//em2.PrintInfo();
//em3.PrintInfo();
//Console.WriteLine("Employees No: " + Employee.counter);


//public static string name = "Ali";
//public static int age = 34;
//public static string companyName = "Muhammed";
//public static int counter = 0;

//public static void PrintInfo()
//{
//    Console.WriteLine("name: " + name + "   age: " +
//        age + "  Company Name  " + companyName);
//}