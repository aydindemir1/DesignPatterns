using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesignPattern
{
    // Client code
    public class NotificationService
    {
        private readonly INotification _notification;
        private readonly INotificationTemplate _template;

        public NotificationService(INotificationFactory factory)
        {
            _notification = factory.CreateNotification();
            _template = factory.CreateTemplate();
        }

        public void SendNotification(string message)
        {
            string template = _template.GetTemplate();
            _notification.Notify($"{template}: {message}");
        }
    }
}
