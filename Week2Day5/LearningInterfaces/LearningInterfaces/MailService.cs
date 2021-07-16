using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningInterfaces
{
    public class MailService: INotificationService
    {
        public void Send(double amount)
        {
            Console.WriteLine("Sending email for the transaction : {0}", amount);
        }
    }
}
