using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesignPattern
{
    // Concrete Factory 2
    public class MobileGameFactory : IGameFactory
    {
        public ICharacter CreateCharacter()
        {
            return new MobileCharacter();
        }

        public IWeapon CreateWeapon()
        {
            return new MobileWeapon();
        }
    }
}
