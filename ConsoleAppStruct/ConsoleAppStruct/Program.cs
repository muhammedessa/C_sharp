using System;

namespace ConsoleAppStruct
{

    struct Result
    {
        public int num1;
        public int num2;
        
        public Result(int n1 , int n2)
        {
            num1 = n1;
            num2 = n2;
        }
        public void PrintInfo()
        {
            Console.WriteLine("Sum is : " + ( num1 +  num2));
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Result res = new Result(20,50);
            res.PrintInfo();
           
            
        }
    }
}
