using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesignPattern
{
    // Concrete Factory 1
    public class SqlFactory : IDbFactory
    {
        public IDbConnection CreateConnection()
        {
            return new SqlConnection();
        }

        public IDbCommand CreateCommand()
        {
            return new SqlCommand();
        }
    }
}
