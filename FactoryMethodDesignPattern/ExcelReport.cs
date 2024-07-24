using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodDesignPattern
{
    // Concrete Product 2
    public class ExcelReport : IReport
    {
        public void Generate()
        {
            Console.WriteLine("Generating Excel Report.");
        }
    }
}
