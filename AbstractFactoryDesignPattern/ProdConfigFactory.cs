using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesignPattern
{
    // Concrete Factory 2
    public class ProdConfigFactory : IConfigFactory
    {
        public IDatabaseConfig CreateDatabaseConfig()
        {
            return new ProdDatabaseConfig();
        }

        public ILoggingConfig CreateLoggingConfig()
        {
            return new ProdLoggingConfig();
        }
    }
}
