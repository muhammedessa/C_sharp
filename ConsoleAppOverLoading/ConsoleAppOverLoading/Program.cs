using System;

namespace ConsoleAppOverLoading
{

    class MAthMatic
    {
        public static int add(int x , int y)
        {
            return x + y;
        }

        public static double add(double x, double y)
        {
            return x + y;
        }

        public static int add(int x, int y , int z)
        {
            return x + y+z;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
        //    MAthMatic maty = new MAthMatic();


    Console.WriteLine("the results: " + MAthMatic.add(1,2) 
        +"  " + MAthMatic.add(1,2,3) + "  " + MAthMatic.add(1.2, 2.1 ));
        }
    }
}
