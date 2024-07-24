using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodDesignPattern
{
    // Concrete Product 1
    public class Warrior : IGameCharacter
    {
        public void Attack()
        {
            Console.WriteLine("Warrior attacks with sword.");
        }
    }
}
