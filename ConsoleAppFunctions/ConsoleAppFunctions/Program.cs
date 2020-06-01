using System;

namespace ConsoleAppFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
           string fullName =  program.Muhammed("Khalid bin Waleed");
           string secondName =  Essa("Omar");
            int myAge = MyAge(22);

            Console.WriteLine("Hello :" + fullName);
            Console.WriteLine("Hello :" + secondName);
             Console.WriteLine("Hello :" + myAge);
        }


        static int MyAge(int age)
        {
            return age +1;
        }

        string Muhammed(string name)
        {
           return name;
        }

        static string Essa(string name)
        {
            return name;
        }







        //void Muhammed(string name)
        //{
        //    Console.WriteLine("Hello :" + name);
        //}

        //static void Essa(string name)
        //{
        //    Console.WriteLine("Hello : " + name );
        //}

        //  void Muhammed()
        //{
        //    Console.WriteLine("Muhammed Essa!");
        //}

        //static void Essa()
        //{
        //    Console.WriteLine(" Essa Hameed!");
        //}




    }
}
