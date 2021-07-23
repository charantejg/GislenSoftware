using System;
using System.Threading;
using System.Threading.Tasks;

namespace TasksDemo
{
    class Program
    {
        static void Main(string[] args)
        {
          // TPL - Task Parallel Library  and do the asynchronous programming 
          // TASKS 

          var task1 = Task<string>.Factory.StartNew(() =>
          {
              Thread.Sleep(20000);
              return "This is my first Task";

              // throw exception

          },new CancellationToken());

          var task2 = Task.Factory.StartNew(() =>
          {
              Thread.Sleep(100);
              Console.WriteLine("This is my second Task");
          });

          var task3 = new Task(()=>
          {
              Console.WriteLine("This is my third Task");
          });

          
          //Task Result 
          Console.WriteLine("Job before  Task1");

          task3.Wait();
            
          Console.WriteLine("Job after  Task1");

        }
    }
}
