using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesignPattern
{
    // Concrete Product B1
    public class DevLoggingConfig : ILoggingConfig
    {
        public void Setup()
        {
            Console.WriteLine("Setting up development logging.");
        }
    }
}
