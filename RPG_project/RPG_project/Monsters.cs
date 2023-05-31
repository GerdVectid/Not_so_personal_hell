using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RPG_project
{
    internal class Monsters
    {

        public static int[] generateMonster()
        {
            Random rnd = new Random();
            int[] monsterStatystic = new int[4];
            for (int i = 0; i < monsterStatystic.Length; i++)
            {
                monsterStatystic[i] = rnd.Next(20,30);
            }
            return monsterStatystic;
        }

        public static int[] fight(int[] player)
        {
            Console.WriteLine("You encounter an adversary");
            int[] monster = genrateMonster();
            while (monster[0] > 0)
            {
                player[0] -= monster[1];
                monster[0] -= player[1];
                if (player[0] <= 0)
                {
                    Console.WriteLine("You die in ungodly pain !!!");
                    break;

                }
                Thread.Sleep(900);
                Console.WriteLine($"Fight! Your Hp {player[0]}, they deal {monster[1]} damage \t You deal {player[1]} damage to your adversary, monsters Hp {monster[0]}");
            }
            player[3] += monster[3];
            return player;
        }



    }
}
