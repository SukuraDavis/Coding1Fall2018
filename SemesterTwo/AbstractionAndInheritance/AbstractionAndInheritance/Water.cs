using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractionAndInheritance
{
    class Water : Drink
    {
        public Water (float weight, float rarity, float cost, string description)
            : base(weight, rarity, cost, description)
        {

        }
    }
}
