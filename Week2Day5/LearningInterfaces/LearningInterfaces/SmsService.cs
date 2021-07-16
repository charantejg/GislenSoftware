using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningInterfaces
{
  public  class SmsService : INotificationService
    {
        public void Send(double amount)
        {
            Console.WriteLine("Sending Sms for the transaction : {0}", amount);
        }

    }
}
