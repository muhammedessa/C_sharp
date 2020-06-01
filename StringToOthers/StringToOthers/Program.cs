using System;

namespace StringToOthers
{
    class Program
    {
        static void Main(string[] args)
        {
           

            string age = "36";
            string salary = "23.45wqw";

            int myAge = int.Parse(age);
            double mySalary;
            if (double.TryParse(salary , out mySalary))
            {
                Console.WriteLine("mySalary " + mySalary );
            }
            else
            {
                Console.WriteLine("can not converted "  );
            }
           

            Console.WriteLine("age " + age.GetType());
            Console.WriteLine("myAge " + myAge.GetType());
            Console.WriteLine("----------------");
            Console.WriteLine("salary " + salary.GetType());
          
        }
    }
}
