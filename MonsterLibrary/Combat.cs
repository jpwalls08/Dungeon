using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CharacterLibrary;

namespace MonsterLibrary
{
    public class Combat
    {
        //This class will not have any fields, properties, or constructors. It is just
        //a method warehouse for combat functionality

        public static void DoAttack(Character attacker, Character defender)
        {
            //get a random number from 1-100 as our dice roll
            Random rand = new Random();
            int diceRoll = rand.Next(1, 101);
            Thread.Sleep(300);//1000 is one second
            if (diceRoll <= (attacker.CalcHitChance() - defender.CalcBlock()))
            {
                //we hit!
                //calculate the damage and save it to a variable!
                int damageDealt = attacker.CalcDamage();

                defender.MinHealth -= damageDealt;

                //write the result to the screen
                Console.ForegroundColor = ConsoleColor.Red;
                Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine($"{attacker.Name} hit {defender.Name} for {damageDealt} damage!");
                Console.ResetColor();
            }//end if
            else
            {
                //attacker missed!
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.White;
                Console.WriteLine($"{attacker.Name} missed!");
                Console.ResetColor();
            }//end else
        }//end DoAttack()

        public static void DoBattle(Player player, Monster monster)
        {
            //player attacks first
            DoAttack(player, monster);
            //monster attacks second, if they're alive
            if (monster.MinHealth > 0)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.Red;
                DoAttack(monster, player);
            }
        }//end DoBattle()
    }//end class
}//end namespace
