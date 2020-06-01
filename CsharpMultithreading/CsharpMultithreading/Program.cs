using System;
using System.Threading;

namespace CsharpMultithreading
{

    public class MuhammedThread
    {
        public static void ThreadMethod()
        {
            for(int x = 0; x < 5; x++)
            {
                Console.WriteLine("Number : " + x);
            }
        }
    }

    public class EssaThread
    {
        public   void ThreadMethod()
        {
            Thread th = Thread.CurrentThread;
            Console.WriteLine("Name : " + th.Name);
            //for (int x = 0; x < 5; x++)
            //{
            //    Console.WriteLine("Number : " + x);
            //    Thread.Sleep(1000);
            //}
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            //Thread th = Thread.CurrentThread;
            //th.Name = "My Thread";
            //Thread th1 = new Thread(new ThreadStart(MuhammedThread.ThreadMethod));
            //Thread th2 = new Thread(new ThreadStart(MuhammedThread.ThreadMethod));

            //th1.Start();
            //th2.Start();

            EssaThread eth = new EssaThread();
            Thread th1 = new Thread(new ThreadStart(eth.ThreadMethod));
            Thread th2 = new Thread(new ThreadStart(eth.ThreadMethod));
            Thread th3 = new Thread(new ThreadStart(eth.ThreadMethod)); 
            Thread th4 = new Thread(new ThreadStart(eth.ThreadMethod));

            th1.Name = "Player Muhammed";
            th2.Name = "Player Essa";
            th3.Name = "Player Hameed";
            th4.Name = "Player Khalid";

            th4.Priority = ThreadPriority.Highest;
            th2.Priority = ThreadPriority.Lowest;
            th1.Priority = ThreadPriority.Lowest;
            th3.Priority = ThreadPriority.Normal;

            th1.Start();
           // th1.Join();
            th2.Start();
            th3.Start();
            th4.Start(); 

        }
    }
}
