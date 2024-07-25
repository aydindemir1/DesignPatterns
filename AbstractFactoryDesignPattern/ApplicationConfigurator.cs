using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesignPattern
{
    // Client code
    public class ApplicationConfigurator
    {
        private readonly IDatabaseConfig _databaseConfig;
        private readonly ILoggingConfig _loggingConfig;

        public ApplicationConfigurator(IConfigFactory factory)
        {
            _databaseConfig = factory.CreateDatabaseConfig();
            _loggingConfig = factory.CreateLoggingConfig();
        }

        public void Configure()
        {
            _databaseConfig.Configure();
            _loggingConfig.Setup();
        }
    }
}
