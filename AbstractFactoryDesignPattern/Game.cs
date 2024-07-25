using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesignPattern
{
    // Client code
    public class Game
    {
        private readonly ICharacter _character;
        private readonly IWeapon _weapon;

        public Game(IGameFactory factory)
        {
            _character = factory.CreateCharacter();
            _weapon = factory.CreateWeapon();
        }

        public void Play()
        {
            _character.Attack();
            _weapon.Use();
        }
    }
}
