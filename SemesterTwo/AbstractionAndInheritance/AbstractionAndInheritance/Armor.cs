using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractionAndInheritance
{
    class Armor : Equipment

    {
        public Armor (float weight, float rarity, float cost, string description)
            : base(weight, rarity, cost, description)
        {

        }
    }
}
