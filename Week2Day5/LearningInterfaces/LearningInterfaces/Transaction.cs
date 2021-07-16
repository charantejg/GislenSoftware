using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningInterfaces
{
    class Transaction
    {
        private readonly IList<INotificationService> _notificationService;

        public Transaction()
        {
            _notificationService = new List<INotificationService>();
        }

        public void Transfer(Account account)
        {
            // Logic
            // Notification  - Email, Sms 

            foreach (var notificationService in _notificationService)
            {
                notificationService.Send(account.Balance);
            }

           

        }
    }
}
