using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CharacterProject
{
    class Character
    {
        public string name;
        public int age;
        public string eye_color;
        public string hair_color;
        public int intelligence;
        public int agility;
        public int strength;
        public Character(string name, int age, string eye_color, string hair_color, int intelligence, int agility, int strength)
        {
            this.name = name;
            this.age = age;
            this.eye_color = eye_color;
            this.hair_color = hair_color;
            this.intelligence = intelligence;
            this.agility = agility;
            this.strength = strength;
        }
    }
}
