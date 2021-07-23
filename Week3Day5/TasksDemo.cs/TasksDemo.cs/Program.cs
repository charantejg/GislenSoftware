using System;
using System.Threading;

namespace ThreadSyncDemo.cs
{
    class Program
    {
        public static int Result = 0;
        private static object lockHandle = new object();

        public static EventWaitHandle readyForResult = new AutoResetEvent(false);
        public static EventWaitHandle setReuslt = new AutoResetEvent(false);

        public static void DoWork()
        {
        
            while (true)
            {
                int i = Result;
                // some logical calculation
                Thread.Sleep(1);

                readyForResult.WaitOne();
               
                lock (lockHandle)
                {
                    Result = i + 1;
                }
                
                setReuslt.Set();

            }
        }

        static void Main(string[] args)
        {
            Thread t1 = new Thread(DoWork);
            t1.Start();
            
           

            Thread.Sleep(10);
            for (int i = 0; i < 100; i++)
            {
                readyForResult.Set();

                setReuslt.WaitOne();

                lock (lockHandle)
                {
                    Console.WriteLine(Result);
                }
             
            }

         


        }
    }
}


