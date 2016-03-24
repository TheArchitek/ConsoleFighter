using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace attackGame
{
    class Attack
    {
        public string AttackerName { get; set; }
        public string DefenderName { get; set; }
        public int HP { get; set; }

        public Attack(string atkName, int hp)
        {
            AttackerName = atkName;
            //Defendername = defName;
            HP = hp;
        }

        /// <summary>
        /// If then statements of current HP.
        /// </summary>
        /// <param name="hp"></param>
        /// <param name="Damage"></param>
        public void Attacking(ref int hp, string AttackerName, string DefenderName, int Damage)
        {
            Console.WriteLine("An attack is about to be made!");
            if (hp > 0)
            {
                Console.WriteLine("{0} caused {1} damage!", AttackerName, Damage);
                hp -= Damage;
                Console.WriteLine("{0} has {1} hp left!", DefenderName, hp);
                Console.ReadLine();
            }
            else if (hp < 50 && hp > 25)
            {
                Console.WriteLine("Careful! You don't have much HP left!");
                Console.ReadLine();

                Console.WriteLine("{0} caused {1} damage!", AttackerName, Damage);
                hp -= Damage;
                Console.WriteLine("{0} has {1} hp left!", DefenderName, hp);
                Console.ReadLine();
            }
            else if (hp < 25)
            {
                Console.WriteLine("{0} caused {1} damage!", AttackerName, Damage);
                hp -= Damage;
                if (hp <= 0)
                {
                    Console.WriteLine("You're Dead!");
                }
                else
                {
                    Console.WriteLine("You're almost dead!");
                    Console.WriteLine("{0} has {1} hp left!", DefenderName, hp);

                }
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("You're dead!");
            }
            
        }
        //public void CounterAttack(ref int hp)
        //{
        //    hp -= Damage;
            
        //    Console.WriteLine("{0} counter attacks for {1} damage, you have {2} hp left!", Name, Damage, hp);
        //    Console.ReadLine();
        //}

       
        
    }
}
