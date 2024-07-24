using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesignPattern
{
    // Concrete Product A1
    public class EmailNotification : INotification
    {
        public void Notify(string message)
        {
            Console.WriteLine($"Sending Email: {message}");
        }
    }
}
