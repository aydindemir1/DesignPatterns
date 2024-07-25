using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesignPattern
{
    // Concrete Product B2
    public class MobileWeapon : IWeapon
    {
        public void Use()
        {
            Console.WriteLine("Mobile weapon: using a touch attack.");
        }
    }
}
