using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodDesignPattern
{
    // Creator
    public abstract class NotificationFactory
    {
        public abstract INotification CreateNotification();
    }
}
