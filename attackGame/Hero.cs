using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace attackGame
{
    public class Hero
    {
        public string Name { get; set; }
        public int HP = 100;
        public int MinDamage = 10;
        public int MaxDamage = 20;

        public Hero(string name, int hp, int minDamage, int maxDamage)
        { 
            Name = name;
            HP = hp;
            MinDamage = minDamage;
            MaxDamage = maxDamage;
        }

        public override string ToString()
        {
            return String.Format("Name: {0}, Health: {1}, Damage: {2} - {3}.", Name, HP, MinDamage, MaxDamage);
        }
    }
}
