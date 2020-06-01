using System;

namespace ConsoleForeachLoop
{
    class Program
    {
        static void Main(string[] args)
        {
          

     string[] myColor =  {  "red" , "white" , "blue" , "yellow","Black" };

            foreach(var color in myColor)
            {
                //if(color == "white")
                //{
                //    break;
                //}
                if (color == "white")
                {
                    continue;
                }
                Console.WriteLine("Color is :" + color);
            }


        }
    }
}
