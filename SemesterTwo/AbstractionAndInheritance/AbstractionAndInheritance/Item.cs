using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractionAndInheritance
{
   abstract class Item
   {
        public float weight;
        public float rarity;
        public float cost;
        public string description;

        public Item(float weight, float rarity, float cost, string description)
        {
            this.weight = weight;
            this.rarity = rarity;
            this.cost = cost;
            this.description = description;
        }
   }
}
