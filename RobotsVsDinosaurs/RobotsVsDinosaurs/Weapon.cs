﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    class Weapon
    {
        //member variables (HAS A)
        public string weaponType;
        public int attackPower;

        //constructor (SPAWNER)
        public Weapon()
        {
            weaponType = "tazer";
            attackPower = 20;
        }
    }
}
