using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodDesignPattern
{
    // Concrete Product 1
    public class PdfReport : IReport
    {
        public void Generate()
        {
            Console.WriteLine("Generating PDF Report.");
        }
    }
}
