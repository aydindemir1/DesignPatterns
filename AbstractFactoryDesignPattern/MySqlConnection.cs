using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesignPattern
{
    // Concrete Product A2
    public class MySqlConnection : IDbConnection
    {
        public void Connect()
        {
            Console.WriteLine("Connecting to MySQL.");
        }
    }
}
