using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesignPattern
{
    // Concrete Product A1
    public class DevDatabaseConfig : IDatabaseConfig
    {
        public void Configure()
        {
            Console.WriteLine("Configuring development database.");
        }
    }
}
