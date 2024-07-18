using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDesignPattern
{
    public class DatabaseConnection
    {
        private static DatabaseConnection instance = null;
        private static readonly object padlock = new object();
        private string connectionString;

        private DatabaseConnection()
        {
            connectionString = "YourConnectionStringHere";
        }

        public static DatabaseConnection Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new DatabaseConnection();
                    }
                    return instance;
                }
            }
        }

        public void OpenConnection()
        {
            Console.WriteLine("Database connection opened.");
        }

        public void CloseConnection()
        {
            Console.WriteLine("Database connection closed.");
        }
    }

}
