using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodDesignPattern
{
    // Bildirim arayüzü
    public interface INotification
    {
        void Notify(string message);
    }
}
