using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Threading;

namespace EventDemoProgram
{

    class Program
    {
        public delegate void myHandler();

        static void Main(string[] args)
        {
            var customer = new Customer() {Name = "Peter", TotalBill = 1500};
            var billing = new Billing();
            billing.CalculateBill(customer);

            var emailService = new EmailService();
            var smsService = new SmsService();
            //myHandler handler = emailService.SendEmail;
            //handler += smsService.SendSms;
            //handler = null;
            //billing.ProcessCommunication(handler);

            //assign the publisher to the subscriber 
            billing.BillingEvent += emailService.SendEmail;
            billing.BillingEvent += smsService.SendSms;
          
            billing.CalculateBill(customer);

        }

    }

    class Customer
    {
        public string Name { get; set; }
        public double TotalBill { get; set; }
    }

    class Billing
    {

        //1. Define the delegate
       // public delegate void BillingEventHandler(object source, EventArgs args); 
        //2. Define the event of type Delegate 
        public event EventHandler BillingEvent;

        //3. Raise the event
        protected virtual void OnBillingEvent(string name)
        {
            if (BillingEvent != null)
                BillingEvent(this, new MyOwnArgs(){myargName = name}  );
        }

        

        public void CalculateBill(Customer customer , MyOwnArgs args)
        {
            Console.WriteLine("Calculating the bill for customer "+ customer.Name);

            // Logics 
            Thread.Sleep(3000);

            OnBillingEvent(args.myargName);
            // Send email
            // Send SMS 
            // Add discount

        }

        //public void ProcessCommunication(Program.myHandler handler)
        //{
        //    handler();
        //}
    }

    class EmailService
    {
        public void SendEmail(object source, MyOwnArgs args)
        {
            Console.WriteLine("Sending email " + args.myargName);
        }


    }

    class SmsService
    {
        public void SendSms(object source, EventArgs args)
        {
            Console.WriteLine("Sending Sms");
        }
    }

    class MyOwnArgs :  EventArgs
    {
        public string myargName { get; set; }
    }
    

}
