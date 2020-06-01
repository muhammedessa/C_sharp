using System;

namespace ConsoleAppSysException
{
    class Program
    {
        static void Main(string[] args)
        {


            try
            {
                double[] myArray = new double[3];
                myArray[0] = 12;
                myArray[1] = 22;
                myArray[2] = 33;
                myArray[12] = 1;
            }
            catch(SystemException e)
            {
                Console.WriteLine(e);
            }



           
        }
    }
}
