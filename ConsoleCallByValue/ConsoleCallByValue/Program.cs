using System;

namespace ConsoleCallByValue
{
    class Program
    {


        static int myage = 36;


        static void Main(string[] args)
        {
            int orginalNum = 20;

            Console.WriteLine("inside Main function: " + myage);
            MyData2();
        }


        static void MyData2()
        {
            int mynum = 10;  
            Console.WriteLine("inside MyData2 function: " + myage);
        }













        static void MyData(ref int num)
        {
            num += num;
            Console.WriteLine("inside function: " + num);
        }


        static void MyResult(out int num)
        {
            int num2 = 10;
            num = num2;
            num *= num;
        }

    }
}
