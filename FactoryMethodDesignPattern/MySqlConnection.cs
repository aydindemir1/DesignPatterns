using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodDesignPattern
{
    // Concrete Product 2
    public class MySqlConnection : IDatabaseConnection
    {
        public void Connect()
        {
            Console.WriteLine("Connected to MySQL Database.");
        }
    }
}
