﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesignPattern
{
    // Concrete Product B2
    public class ExcelChart : IChart
    {
        public void Draw()
        {
            Console.WriteLine("Drawing Excel chart.");
        }
    }
}
