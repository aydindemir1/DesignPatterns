using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesignPattern
{
    // Concrete Product A1
    public class SqlConnection : IDbConnection
    {
        public void Connect()
        {
            Console.WriteLine("Connecting to SQL Server.");
        }
    }
}
