using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesignPattern
{
    // Concrete Factory 1
    public class PdfReportFactory : IReportFactory
    {
        public IReport CreateReport()
        {
            return new PdfReport();
        }

        public IChart CreateChart()
        {
            return new PdfChart();
        }
    }
}
