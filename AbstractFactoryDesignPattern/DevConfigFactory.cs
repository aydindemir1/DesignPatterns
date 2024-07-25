using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesignPattern
{
    // Concrete Factory 1
    public class DevConfigFactory : IConfigFactory
    {
        public IDatabaseConfig CreateDatabaseConfig()
        {
            return new DevDatabaseConfig();
        }

        public ILoggingConfig CreateLoggingConfig()
        {
            return new DevLoggingConfig();
        }
    }
}
