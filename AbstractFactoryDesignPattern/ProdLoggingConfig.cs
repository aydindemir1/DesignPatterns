using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesignPattern
{

    // Concrete Product B2
    public class ProdLoggingConfig : ILoggingConfig
    {
        public void Setup()
        {
            Console.WriteLine("Setting up production logging.");
        }
    }
}
