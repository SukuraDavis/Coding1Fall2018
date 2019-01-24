using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractionAndInheritance
{
    class Soda : Drink
    {
        public Soda (float weight, float rarity, float cost, string description)
            : base(weight, rarity, cost, description)
        {

        }
    }
}
