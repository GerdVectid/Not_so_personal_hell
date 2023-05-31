using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_project
{
    public class Shop
    {
        public static int[] shop(int[] character, int maxHp, int maxMana)
        {
            Console.WriteLine("Welcome to my shop!!!");
            Console.WriteLine("1 - heal 2g \t 2 - Att up 10g \t 3 - Mana up 10g \t any button - leave");

            int inp = int.Parse(Console.ReadLine());
            switch (inp)
            {
                case 1:
                    return heal(character, maxHp);
                case 2:
                    return upAtac(character);
                case 3:
                    return upMana(character);
            }
            Console.WriteLine("You leave the shop");
            return character;
        }

        public static int[] heal(int[] character, int maxHp)
        {
            Random rnd = new Random();
            int heal = rnd.Next(10,20);
            Console.WriteLine(character[0]);
            if (character[3] >= 2)
            {
                Console.WriteLine("You pay 2 g");
                character[3] -= 2;
                if (character[0] + heal >= maxHp)
                {
                    Console.WriteLine("You have been completelly healed");
                    character[0] = maxHp;
                    return character;
                }
                else 
                {
                    Console.WriteLine($"You were healed by {heal}, you have {character[0]}hp");
                    character[0] += heal;
                    return character;
                }
            }
            Console.WriteLine("You can't afford such luxury");
            return character;
        }


        public static int[] upAtac(int[] character)
        {
            if (character[3] >= 10)
            {
                Console.WriteLine("Your damage increased by 5, you paid 10 g to the shop keeper");
                character[3] -= 10;
                character[1] += 5;
            }
            else
            {
                Console.WriteLine("You don't have enought gold for such luxury");
            }
            return character;
        }

        public static int[] upMana(int[] character)
        {
            if (character[3] >= 10)
            {
                Console.WriteLine("Your mana increased by 50, you paid the price of 10 gold for that");
                character[3] -= 10;
                character[2] += 50;
            }
            else
            {
                Console.WriteLine("You don't have enought gold for such luxury");
            }
            return character;
        }
    }
}
