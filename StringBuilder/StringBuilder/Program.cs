using System;
using System.Text;

namespace StringBuilder2
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Muhammed";
            string secondName = "Essa";

            StringBuilder sb = new StringBuilder();
            sb.Append("Muhammed") 
             .Append(" Essa") 
             .Append(" Hameed") 
            .Append(" Essa") 
            .Append(" Muhammed");



            Console.WriteLine(sb.ToString());
        }
    }
}
