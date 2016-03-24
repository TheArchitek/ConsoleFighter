using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace attackGame
{
    class Program
    {
        

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the one on one fight game! So what is your name, challenger?");
            string userInput = Console.ReadLine();
            Console.WriteLine("Well then {0}, looks like you've got a fight for the ages in front of you today!", userInput);

            Hero userHero = new Hero(userInput, 100, 10, 35);
            Console.WriteLine(userHero);
            Console.ReadLine();

            Boss elDiablo = new Boss("El Diablo", 100, 20, 25);
            Console.WriteLine("In the red corner we have the undefeated {0}!", elDiablo);
            Console.ReadLine();

            Random HeroRndAttackRange = new Random();
            Random BossRndAttackRange = new Random();

            Attack bossAttack = new Attack(elDiablo.Name, userHero.HP);
            Attack heroAttack = new Attack(userInput, elDiablo.HP);
            while (elDiablo.HP > 0 && userHero.HP > 0)
            {    
                heroAttack.Attacking(ref elDiablo.HP, userHero.Name, elDiablo.Name, HeroRndAttackRange.Next(userHero.MinDamage, userHero.MaxDamage));
                bossAttack.Attacking(ref userHero.HP, elDiablo.Name, userHero.Name, BossRndAttackRange.Next(elDiablo.MinDamage, elDiablo.MaxDamage));
            }
            if (elDiablo.HP > 0)
            {
                Console.WriteLine("{0} is the winner, you're dead!", elDiablo.Name);
            }else
            {
                Console.WriteLine("{0} is the winner, congratz you fucking scrub!", userInput);
            }

            Console.WriteLine("The fight is over, go on, get.");

        }
    }
}
