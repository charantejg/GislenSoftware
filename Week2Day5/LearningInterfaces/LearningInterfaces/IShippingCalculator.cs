using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningInterfaces
{
   public interface IShippingCalculator
   {
       float Calculate(double totalPrice);

       float FrieghtCharges(double totalPrice);

   }
}
