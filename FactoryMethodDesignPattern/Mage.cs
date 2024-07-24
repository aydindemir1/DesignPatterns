using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodDesignPattern
{
    // Concrete Product 2
    public class Mage : IGameCharacter
    {
        public void Attack()
        {
            Console.WriteLine("Mage attacks with magic.");
        }
    }
}
