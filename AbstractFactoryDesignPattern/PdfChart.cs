using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesignPattern
{
    // Concrete Product B1
    public class PdfChart : IChart
    {
        public void Draw()
        {
            Console.WriteLine("Drawing PDF chart.");
        }
    }
}
