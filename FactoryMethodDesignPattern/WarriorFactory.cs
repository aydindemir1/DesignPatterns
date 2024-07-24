﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodDesignPattern
{
    // Concrete Creator 1
    public class WarriorFactory : CharacterFactory
    {
        public override IGameCharacter CreateCharacter()
        {
            return new Warrior();
        }
    }
}
