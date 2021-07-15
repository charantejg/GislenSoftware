using System;
using System.Reflection.Metadata;
using System.Web;

namespace DemoW2D4
{
    class Program
    {
        static void Main(string[] args)
        {
           //Constructor calls between classes
           var shippingChargesObj = new ShippingCharges(10.00, "ABC0987");

           // Up-casting , Down-Casting 
           // Order  - parent 
           // Shipping - Child 
           var orderObj = new Order();
           var shippingObj = new ShippingCharges();
           
           //Down-casting  - Parent to Child
           //var newChildObject = (ShippingCharges) orderObj;
           
           
           // Up-casting  - Child to Parent 
           // newChildObject = shippingObj;


            //Abstraction 
            // Abstract Modifier 

            var squareObj = new Square();
            squareObj.Draw();
            squareObj.GetColor();
            squareObj.DrawSuper();

            // sealed class
            var myFinacne = new Finance();
            myFinacne.Info();

            // static class
            var utcTime = Utility.GetCurrentTimeInUTC();
            var indiaTime = Utility.GetIndiaCurrentTime();

            

        }
    }


    class Order
    {

        private string _orderId;
        public string  OrderDesc { get; set; }
        protected string MoreDesc { get; set; }
        internal string InternalInfo { get; set; }
        
        public Order()
        {
            // init
        }

        public Order(string orderId)
        {
            _orderId = orderId;
            Console.WriteLine("Order Constructor is called with order Id {0}", _orderId);
        }

        public Order(string orderId, string customer)
        {
            _orderId = orderId;
            Console.WriteLine("Order Constructor is called with order Id {0} for Customer {1}", 
                _orderId, customer);
        }
        
    }

    class ShippingCharges: Order
    {
        private double  _shippingFee { get; set; }
        public string ShippingDesc { get; set; }

        public ShippingCharges()
        {
            
        }
        
        public ShippingCharges(double shippingFee, string orderId) : base(orderId, "New Customer")
        {
            var moreInfo = MoreDesc;
            _shippingFee = shippingFee;
            Console.WriteLine(" Shipping Constructor is called with charges: "+ _shippingFee  + "," 
                              + orderId);
        }






    }


}
