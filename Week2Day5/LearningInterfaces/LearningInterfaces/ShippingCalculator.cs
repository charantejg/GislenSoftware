using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningInterfaces
{
  public class ShippingCalculator: IShippingCalculator
    {
        public float Calculate(double totalPrice)
        {
            return totalPrice < 100 ? 5 : 10;
        }

        public float FrieghtCharges(double totalPrice)
        {

            return 0;
        }

    }

  class Fee
  {
      public float Charges { get; set; }
      public float FrieightCharge { get; set; }
  }
}
