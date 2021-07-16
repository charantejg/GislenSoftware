using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningInterfaces
{
   public class OrderProcessing
   {
       private readonly IShippingCalculator _shippingCalculator;

        public OrderProcessing(IShippingCalculator shippingCalculator)
        {
            _shippingCalculator = shippingCalculator;
        }


        public Order Process(Order order)
        {
            if (order.IsShipped)
            {
                // do nothing
            }
            
            order.Shipment = new Shipment
            {
                DeliveryCharges = _shippingCalculator.Calculate(order.TotalPrice),
                ShipmentmentDate =  DateTime.Today.AddDays(2)
            };

            return order;
        }


    }
}
