using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodDesignPattern
{
    // Concrete Product 1
    public class SqlConnection : IDatabaseConnection
    {
        public void Connect()
        {
            Console.WriteLine("Connected to SQL Database.");
        }
    }
}
