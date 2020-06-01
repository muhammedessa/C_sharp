using System;

namespace ConsoleAppOOP
{


  public class Student
    {
        public  string name;
        public int age;
        public double salary;

        public void AddData(string name1 , int age1)
        {
            name = name1;
            age = age1;
        }
        public void PrintData()
        {
            Console.WriteLine(name + " " +   " " + age);
        }
    }


    class Program
    {

        string name;
        int age;
        double salary;

        static void Main(string[] args)
        {
            //Program pro = new Program();
            //pro.name = "Muhammed Essa Hameed";
            //pro.age = 36;
            //pro.salary = 3000.34;

            Student std1 = new Student();
            std1.AddData("Muhammed Essa", 30);
            Student std2 = new Student();
            std2.AddData("Ahmed Ali", 26);

            // Console.WriteLine(pro.name+ " " + pro.age + " " + pro.salary);
            Console.WriteLine("------------------");
            std1.PrintData(); 
            std2.PrintData();
           
        }
    }
}
