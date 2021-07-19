using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace DemoExceptions
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] numbers = new[] {10, 2, 6, 4, 1, 15};
            

            var result =    from number in numbers
                                        where number < 6
                                        select number;


            foreach (var number in numbers)
            {

                Console.WriteLine(number);
            }

            Console.WriteLine(String.Join(",", result));


            var calculator = new Calculator();

            var reader = new FileReader();
            var text = reader.ReadFile("C:\\Data\\projects\\learning\\GislenSoftwateLiveCode\\Week3Day1\\demo.txt");


            try
            {
                int divideResult = calculator.Divide(10, 0);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                
            }






        }
    }


    class Calculator
    {
        public int Divide(int i, int j)
        {

            try
            {
                return i / j;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw new CustomException("this is my new custom", "002", e);
            }
         
        }
    }

    class FileReader
    {
        

        public string ReadFile(string fileName)
        {


            //var streamReader = new StreamReader(fileName);
            
            try
            {
                using(var streamReader = new StreamReader(fileName))
                {
                    var result = streamReader.ReadToEnd();
                    return result;
                }
             
            }
           
            catch (Exception e)
            {
                Console.WriteLine(e.Message + "," + e.StackTrace);
                return String.Empty;
                
            }
            
        }

       

    }


   
}


