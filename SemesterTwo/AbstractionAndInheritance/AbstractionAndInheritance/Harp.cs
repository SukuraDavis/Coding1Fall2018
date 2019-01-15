using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractionAndInheritance
{
    class Harp : Light
    {
        public Harp (float weight, float rarity, float cost, string description)
            : base(weight, rarity, cost, description)
        {

        }
    }
}
