using System;
using System.Security.Cryptography.X509Certificates;

namespace GenericsDelegateEvent
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //  Generic classes
            var bookList = new BookList();
            bookList.Add(new Book());

            int i = 10;
            float f = 5.1f;
            var genericList = new GenericList<Book>();
            genericList.Add(new Book());
            genericList.GetPrice(new Book(), i);
            genericList.GetPrice(new Book(), f);
            genericList.GetDiscount(10);
            // genericList.Add(new EBook());
           


            // DELEGATES 
            var photo = new Photo() {Path = "c:\\phtoto\\1.jpj"};
            var photoProcessor = new PhotoProcessor();
           // photoProcessor.Process(photo);
            var filters = new PhotoFilter();

            PhotoProcessor.PhotoFilterHandler filterHandler = filters.ApplyBrightness;
            filterHandler += filters.ApplyContrast;

            photoProcessor.ProcessNew(photo, filterHandler);
           
            //Simple example 
            MyDisplayDelegate delegateToDisplay = Display;
            delegateToDisplay = DisplayToBiggerScreen;

            delegateToDisplay("Testing");

   
        }

        public delegate void MyDisplayDelegate(string message);

        static void Display(string message)
        {
            Console.WriteLine("This is from small sreen");
        }

        static void DisplayToBiggerScreen(string message)
        {
            Console.WriteLine("This is from big Screen");
        }


    }

    class PhotoProcessor
    {
        //public void Process(Photo photo)
        //{
        //    var filters = new PhotoFilter();
        //    filters.ApplyBrightness(photo);
        //    filters.ApplyContrast(photo);
            
        //}

        public void ProcessNew(Photo photo, PhotoFilterHandler filterHandler)
        {
            filterHandler(photo);
        }

       public delegate void PhotoFilterHandler(Photo photo);

    }

    class PhotoFilter
    {
        public void ApplyBrightness(Photo photo)
        {
            Console.WriteLine("Applying the Brightness");
        }

        public void ApplyContrast(Photo photo)
        {
            Console.WriteLine("Applying the Contrast");
        }

        // Exposure - 
    }

    public class Photo
    {
        public string Path { get; set; }
    }


    class GenericList<T>
    {
       
        public int price { get; set; }
        public void Add(T myObj)
        {
            //
        }

        public double GetPrice<T1>(T myobj, T1 tax)
        {
            return 0;
        }

        public void GetDiscount(int discount)
        {

        }

    }


    class BookList
    {
        public void Add(Book book)
        {
            // adding logic
        }

        public double GetPrice(Book book, int tax)
        {
            return 0;
        }

    }

    class Book
    {
        public int Isbn { get; set; }
        public string Title { get; set; }
    }

    class EBook
    {
        public string Url { get; set; }
    }

}
