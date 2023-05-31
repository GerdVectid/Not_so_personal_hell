using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_project
{
    internal class Spells
    {
        public static int[] SpellsBook(int[] character, int maxHp, int maxMana)
        {
            Console.WriteLine("a - Major Heal \t b - Sanguine Feast");
            string inp = Console.ReadLine().ToLower();
            switch (inp)
            {
                case "a":
                    return Heal(character,maxHp,maxMana);
                case "b":
                    return Sanguine_Feast(character,maxHp,maxMana);
                default:
                    return character;
            }
        }

        public static int[] Heal(int[] character, int maxHp, int maxMana)
        {
            if (character[2] >= 100)
            {
                character[0] = maxHp;
                character[2] -= 100;
                Console.WriteLine("Your Hp is restored to full");
                return character;
            }
            else
            {
                Console.WriteLine("You are out of mana!");
            }

            return character;
        }
        
        public static int[] Sanguine_Feast(int[] character, int maxHp, int maxMana)
        {
            if (character[1] < 30)
            {
                character[1] += 5;
                character[0] -= 20;
                Console.WriteLine("You sacrifeced your flesh for power!");
                return character;
            }
            else
            {
                Console.WriteLine("You are too powerful to be graced with more power!");
            }
            return character;
        }




    }
}
