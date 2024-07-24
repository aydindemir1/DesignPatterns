using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesignPattern
{
    // Client code
    public class DatabaseClient
    {
        private readonly IDbConnection _connection;
        private readonly IDbCommand _command;

        public DatabaseClient(IDbFactory factory)
        {
            _connection = factory.CreateConnection();
            _command = factory.CreateCommand();
        }

        public void Run()
        {
            _connection.Connect();
            _command.Execute();
        }
    }
}
