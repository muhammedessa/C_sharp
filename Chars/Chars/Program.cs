using System;

namespace Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            char mychar = 'A';
            char mychar2 = '\u006A';
            char mychar3 = '\u0061';
            char mychar4 = '$';

            Console.WriteLine("your char is : " + mychar);
            Console.WriteLine("your char is : " + mychar2);
            Console.WriteLine("your char is : " + mychar3);
   Console.WriteLine("your char is : " + Char.IsLetterOrDigit(mychar4) );
        }
    }
}
