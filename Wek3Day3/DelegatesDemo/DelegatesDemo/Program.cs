using System;

namespace DelegatesDemo
{
    class Program
    {
        

        static void Main(string[] args)
        {
            
           var billingSystem = new BillingSystem();
           var customer1 = new NewCustomer();
           var customer2 = new ExistingCustomer();

           billingSystem.CalculateDiscount(customer1.Discount);
           billingSystem.CalculateDiscount(customer2.Discount);



           Action<int> printAction = Print;
           Func<int, int> displayAction = Display;
           var result = displayAction(10);

        }

        static void Print(int val)
        {
            Console.WriteLine(val * 10);
        }

        static int Display(int val)
        {
            return val * 10;
        }

    }


    class BillingSystem
    {
        public delegate void DiscountHandler();

        public void PrintBill()
        {
            Console.WriteLine("The bill amount");
        }
         
        public void CalculateDiscount(DiscountHandler handler)
        {

            handler();
        }
        
    }

   

    class NewCustomer
    {
        public void Discount()
        {
            Console.WriteLine("The discount is 10%");
        }

    }

    class  ExistingCustomer
    {
        public void Discount()
        {
            Console.WriteLine("The discount is 20%");
        }
    }
}
