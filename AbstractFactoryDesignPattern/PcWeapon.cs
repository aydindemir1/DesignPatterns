using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesignPattern
{
    // Concrete Product B1
    public class PcWeapon : IWeapon
    {
        public void Use()
        {
            Console.WriteLine("PC weapon: using a laser.");
        }
    }
}
