using System;

namespace LearningInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {

           // var vehicle = new Vehicle();
           // vehicle.RegistrationNumber = "KA 01 MC 009";

            //down-casting 
            Vehicle vehicle = new Car();


            //up-casting
            Car newCar = (Car) new Vehicle();
         

            // as  and is key words


            //Static class and instance class
            var myMath = new MyMath(1.5f, 2.6f);
            var result = myMath.Add();
            var average = myMath.Average();

            var text = average.ToString();
            // ExtendMath.Average(myMath);

            //Interface

            var order = new Order {DatePlaced = DateTime.Now, TotalPrice = 110.00};

            Console.WriteLine($" Before Processing for total price: {order.TotalPrice} and item");
        


           var orderProcess = new OrderProcessing(new ShippingCalculator());
           var resultOrder =   orderProcess.Process(order);


           Console.WriteLine($"After Processing" +
                             $" Delivery charges are: {resultOrder.Shipment.DeliveryCharges}" +
                             $"for total price:{resultOrder.TotalPrice} and item" +
                             $"will be delivered on : {resultOrder.Shipment.ShipmentmentDate}");

           // Second Example - Account Transfer Notification

           var account = new Account();
           account.Balance = 100;
           var transaction = new Transaction();
           transaction.Transfer(account);


           // Interface - extend 

           // Operator Overloading 

           


        }
    }
}
