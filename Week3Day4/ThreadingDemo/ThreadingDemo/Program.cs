using System;
using System.Threading;

namespace ThreadingDemo
{
    class Program

    {
        private const int Repeat = 10;
        public static int i = 0;

         static int value1 = 1;
         static int value2 = 1; 
        // shared variable 
        // LOCK 

        static void Main(string[] args)
        {
            Thread t1 = new Thread(DoWork);
            Thread t2 = new Thread(DoWork);
           
            t1.Start();
            t2.Start();
            t1.Name = "Trhead1";
            t2.Name = "Thread2";
        }

        static void DoWork()
        {

            lock(syncObject)
            {
                if (value2 > 0)
                {
                    Console.WriteLine(value1 / value2);
                    value2 = 0;
                }
            }
           
        }

        private static object syncObject = new object();
    }

}
