using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            long age = 22L;
            
            double salay = 1200.89; 

            float height = 3000.5f;

            var myage = 20L;

            decimal myMoney = 3_000.5m;

            byte nybyte = 255;

            Console.WriteLine("your age is : " + age.GetType());
            Console.WriteLine("your myage is : " + myage.GetType());
            Console.WriteLine("your height is : " + height.GetType());
            Console.WriteLine("your myMoney is : " + myMoney.GetType());
            Console.WriteLine("your salay is : " + salay.GetType());
            Console.WriteLine("your nybyte is : " + nybyte.GetType());

        }
    }
}
