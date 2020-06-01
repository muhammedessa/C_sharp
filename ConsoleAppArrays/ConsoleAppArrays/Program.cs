using System;

namespace ConsoleAppArrays
{
    class Program
    {
        static void Main(string[] args)
        {


           
            int[,,] array3D = new int[3, 3,3];

            int[,] array2D = new int[3, 3];
            array2D[0,1] = 30;
            array2D[1,2] = 40;
            array2D[2,0] = 50;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(array2D[i,j]);
                }
                Console.WriteLine();
            }


            int[,] array2D2 = { {1,2,3 } , {4,5,6 } , {7,8,9 }   };

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(array2D2[i, j]);
                }
                Console.WriteLine();
            }

            //int[] myArray = new int[4];
            //myArray[0] = 30;
            //myArray[1] = 40;
            //myArray[2] = 50;
            //myArray[3] = 60; 

            //for (int i =0; i< myArray.Length; i++)
            //{
            //    Console.WriteLine(myArray[i]);
            //}

            //int[] myArray2 = new int[4] { 1,2,3,4};

            //for (int i = 0; i < myArray2.Length; i++)
            //{
            //    Console.WriteLine(myArray2[i]);
            //}

            //int[] numbers = { 10,20,30,40,50,60,70,80 };
            //foreach(var x in numbers)
            //{
            //    Console.WriteLine(x);
            //}

            //   string[] names = { "Muhammed","Essa","Hameed" };
            //foreach (var x in names)
            //{
            //    Console.WriteLine(x);
            //}


            //  Console.WriteLine(names.Length);
            //    MyNames(names);

        }

        //static void MyNames(string[] names)
        //{
        //    foreach (var x in names)
        //    {
        //        Console.WriteLine(x);
        //    }
        //}
    }
}
