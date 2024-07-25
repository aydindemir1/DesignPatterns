using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesignPattern
{
    // Concrete Factory 1
    public class PcGameFactory : IGameFactory
    {
        public ICharacter CreateCharacter()
        {
            return new PcCharacter();
        }

        public IWeapon CreateWeapon()
        {
            return new PcWeapon();
        }
    }
}
