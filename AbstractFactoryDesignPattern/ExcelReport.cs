using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesignPattern
{
    // Concrete Product A2
    public class ExcelReport : IReport
    {
        public void Generate()
        {
            Console.WriteLine("Generating Excel report.");
        }
    }
}
