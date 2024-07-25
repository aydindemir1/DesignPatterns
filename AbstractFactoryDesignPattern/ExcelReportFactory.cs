using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesignPattern
{
    // Concrete Factory 2
    public class ExcelReportFactory : IReportFactory
    {
        public IReport CreateReport()
        {
            return new ExcelReport();
        }

        public IChart CreateChart()
        {
            return new ExcelChart();
        }
    }
}
