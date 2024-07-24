using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesignPattern
{
    // Concrete Factory 2
    public class SmsNotificationFactory : INotificationFactory
    {
        public INotification CreateNotification()
        {
            return new SmsNotification();
        }

        public INotificationTemplate CreateTemplate()
        {
            return new SmsTemplate();
        }
    }
}
