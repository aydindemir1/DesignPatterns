using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodDesignPattern
{
    // Creator
    public abstract class Dialog
    {
        public abstract IButton CreateButton();
        public void Render()
        {
            IButton button = CreateButton();
            button.Render();
        }
    }
}
