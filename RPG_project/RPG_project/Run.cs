using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_project
{
    internal class Run
    {
        static void Main(string[] args)
        {
            // hp atack mana gold 
            int[] character = CharacterClass.characterClassSelection();
            int round = 0;

            int maxHp = character[0];
            int maxMana = character[2];

            while (CharacterClass.isAlive(character))
            {
                GameInformation.informations(character, round);
                string inp = Console.ReadLine().ToLower();
                switch (inp)
                {
                    case "e":
                        Console.WriteLine("Fight");
                        Monsters.fight(character);
                        break;
                    case "s":
                        Console.WriteLine("Spells");
                        Spells.SpellsBook(character, maxHp, maxMana);
                        break;
                    case "w":
                        Shop.shop(character, maxHp, maxMana);
                        Console.WriteLine("Shop");
                        break;
                    default:
                        Console.WriteLine("Such choice is not present");
                        break;
                }
                round += 1;
            }

            Console.WriteLine("Thank you for playing");
            Console.ReadKey();
        }
    }
}
