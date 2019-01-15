using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractionAndInheritance
{
    class Cloak : Armor
    {
        public Cloak (float weight, float rarity, float cost, string description)
            : base(weight, rarity, cost, description)
        {

        }
    }
}
