using System;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncDemo
{
    class Program
    {
        public static string Url =
            "https://download.visualstudio.microsoft.com/download/pr/474a078c-f415-4bae-8571-2fe8ea37ed51/a8ac1fe825f63411c375633bd98205c4/dotnet-sdk-5.0.302-win-x64.exe";

        static  void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Download();

            Console.WriteLine("Enter your name: ");
            Console.ReadLine();

        }

       static async void Download()
        {
           // var downloader = new WebClient();
           // var rawData = await downloader.DownloadDataTaskAsync(Url);

           var result = await CustomMethod();
           Console.WriteLine("Download completed");

       
        }

       
       static async Task<String> CustomMethod()
       {
           Thread.Sleep(1000);
           return "Test message";
       }

    }
}


// main program
// custom Download method  (async - await)
// .NET Downloader webclient (Async)

