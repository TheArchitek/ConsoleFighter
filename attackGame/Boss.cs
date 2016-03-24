using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace attackGame
{
    class Boss 
    {
        public string Name = "";
        public int HP = 200;
        public int MinDamage = 20;
        public int MaxDamage = 30;

        public Boss(string name, int hp, int minDamage, int maxDamage)
        {
            Name = name;
            HP = hp;
            MinDamage = minDamage;
            MaxDamage = maxDamage;
        }
        public override string ToString()
        {
            return String.Format("Name: {0}, HP: {1}, Damage: {2} - {3}.", Name, HP, MinDamage, MaxDamage);
        }
    }
}
