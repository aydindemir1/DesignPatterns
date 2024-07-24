﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesignPattern
{
    // Client code
    public class Application
    {
        private readonly IButton _button;
        private readonly ICheckbox _checkbox;

        public Application(IGUIFactory factory)
        {
            _button = factory.CreateButton();
            _checkbox = factory.CreateCheckbox();
        }

        public void Paint()
        {
            _button.Paint();
            _checkbox.Paint();
        }
    }
}
