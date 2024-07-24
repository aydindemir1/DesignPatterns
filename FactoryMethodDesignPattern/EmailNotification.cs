using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodDesignPattern
{
    // Concrete Product 1
    public class EmailNotification : INotification
    {
        public void Notify(string message)
        {
            Console.WriteLine($"Sending Email: {message}");
        }
    }
}
