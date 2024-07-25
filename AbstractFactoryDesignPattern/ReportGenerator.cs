using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesignPattern
{
    // Client code
    public class ReportGenerator
    {
        private readonly IReport _report;
        private readonly IChart _chart;

        public ReportGenerator(IReportFactory factory)
        {
            _report = factory.CreateReport();
            _chart = factory.CreateChart();
        }

        public void GenerateReport()
        {
            _report.Generate();
            _chart.Draw();
        }
    }
}
