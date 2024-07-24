﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesignPattern
{
    // Concrete Product A2
    public class MacButton : IButton
    {
        public void Paint()
        {
            Console.WriteLine("Rendering a button in a MacOS style.");
        }
    }
}
