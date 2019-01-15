using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractionAndInheritance
{
    class Element : Equipment
    {
        public Element(float weight, float rarity, float cost, string description)
            : base(weight, rarity, cost, description)
        {

        }
    }
}
