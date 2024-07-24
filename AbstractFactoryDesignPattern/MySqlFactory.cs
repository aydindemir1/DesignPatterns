using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesignPattern
{
    // Concrete Factory 2
    public class MySqlFactory : IDbFactory
    {
        public IDbConnection CreateConnection()
        {
            return new MySqlConnection();
        }

        public IDbCommand CreateCommand()
        {
            return new MySqlCommand();
        }
    }
}
