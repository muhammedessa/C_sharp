using System;

namespace ConsoleAppException
{

   public class SalaryExceptionInvalid : Exception
    {
        public SalaryExceptionInvalid(String msg) : base(msg)
        {
          
        }
    }


    class Program
    {

        static void verfiySalary(double salary)
        {
            if (salary > 3000)
            {
                throw new SalaryExceptionInvalid("Salary is too high");
            }
        }

        static void Main(string[] args)
        {

            try
            {
                verfiySalary(6000);
            }
            catch (SalaryExceptionInvalid e)
            {
                Console.WriteLine("from catch: " + e);
            }
           




            //try
            //{
            //    int num1 = 50; 
            //    int num2 = 10;
            //    int sum = num1 / num2;
            //    Console.WriteLine("Result: " + sum);
            //}
            //catch(Exception e)
            //{
            //    Console.WriteLine("can not devide by zero" );
            //}
            //finally
            //{
            //    Console.WriteLine("finally can run");
            //}

            Console.WriteLine("Muhammed Essa");
        }
    }
}
