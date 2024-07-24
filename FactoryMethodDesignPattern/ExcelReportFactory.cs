using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodDesignPattern
{
    // Concrete Creator 2
    public class ExcelReportFactory : ReportFactory
    {
        public override IReport CreateReport()
        {
            return new ExcelReport();
        }
    }
}
