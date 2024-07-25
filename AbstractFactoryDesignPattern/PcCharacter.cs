using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesignPattern
{
    // Concrete Product A1
    public class PcCharacter : ICharacter
    {
        public void Attack()
        {
            Console.WriteLine("PC character attacks with a gun.");
        }
    }
}
