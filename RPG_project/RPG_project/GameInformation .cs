using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RPG_project
{
    internal class GameInformation
    {
        public static void informations(int[] charcer, int round)
        {
            Console.WriteLine($"------------------- round - {round} -------------------");
            Console.WriteLine($"Your: \t Hp {charcer[0]} \t Att {charcer[1]} \t Mana {charcer[2]} \t Gold {charcer[3]}");
            Console.WriteLine($"e - Search for enemies | s - Spells |w - Shop |");
            Thread.Sleep(900); 
        }


    }
}
