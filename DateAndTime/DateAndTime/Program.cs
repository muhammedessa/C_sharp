using System;

namespace DateAndTime
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime mydate = new DateTime(2020,4,30);
            DateTime myToday = DateTime.Now;
            Console.WriteLine("Date is : " + myToday.ToString("MMMM d/yyyy"));

            Console.WriteLine("Date is : " + mydate.ToString("M/d/yyyy"));
        }
    }
}
