using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodDesignPattern
{
    // Concrete Creator 2
    public class MacDialog : Dialog
    {
        public override IButton CreateButton()
        {
            return new MacButton();
        }
    }
}
