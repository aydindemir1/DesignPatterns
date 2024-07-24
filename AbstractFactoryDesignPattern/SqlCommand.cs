using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesignPattern
{
    // Concrete Product B1
    public class SqlCommand : IDbCommand
    {
        public void Execute()
        {
            Console.WriteLine("Executing SQL Command.");
        }
    }
}
