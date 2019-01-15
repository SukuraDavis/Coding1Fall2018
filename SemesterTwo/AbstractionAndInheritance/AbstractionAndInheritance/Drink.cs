using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractionAndInheritance
{
    class Drink : Consumable
    {
        public Drink (float weight, float rarity, float cost, string description)
            : base(weight, rarity, cost, description)
        {

        }
    }
}
