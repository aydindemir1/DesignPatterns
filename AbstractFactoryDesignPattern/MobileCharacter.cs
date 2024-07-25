using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesignPattern
{
    // Concrete Product A2
    public class MobileCharacter : ICharacter
    {
        public void Attack()
        {
            Console.WriteLine("Mobile character attacks with a swipe.");
        }
    }
}
