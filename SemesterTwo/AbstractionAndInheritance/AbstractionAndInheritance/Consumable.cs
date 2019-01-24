using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractionAndInheritance
{
    class Consumable : Item
    {
        public Consumable (float weight, float rarity, float cost, string description)
            : base(weight, rarity, cost, description)
        {

        }
    }
}
