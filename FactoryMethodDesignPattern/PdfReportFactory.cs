using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodDesignPattern
{
    // Concrete Creator 1
    public class PdfReportFactory : ReportFactory
    {
        public override IReport CreateReport()
        {
            return new PdfReport();
        }
    }
}
