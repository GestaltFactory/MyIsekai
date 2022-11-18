using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_isekai_lib.Utilities
{
    public static class Randomizer
    {
        private static readonly Random rand = new Random();

        public static int Dice(int min, int max)
        {
            return rand.Next(min, max);
        }

        public static float DiceF()
        {
            return rand.NextSingle();
        }
    }
}
