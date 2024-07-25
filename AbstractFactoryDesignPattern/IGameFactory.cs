using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesignPattern
{
    // Abstract Factory
    public interface IGameFactory
    {
        ICharacter CreateCharacter();
        IWeapon CreateWeapon();
    }
}
