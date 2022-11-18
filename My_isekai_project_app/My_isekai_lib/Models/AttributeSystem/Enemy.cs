using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_isekai_lib.Models.AttributeSystem
{
    public class Enemy : Character
    {
        public int ExpGain { get; set; }
        public Relic? Relic { get; set; }

        /// <summary>
        /// Used to create a new enemy that may (or not) drop a relic
        /// </summary>
        /// <param name="name"></param>
        /// <param name="hp"></param>
        /// <param name="attack"></param>
        /// <param name="defense"></param>
        /// <param name="accuracy"></param>
        /// <param name="expGain"></param>
        /// <param name="relic"></param>
        public Enemy(string name, double hp, double attack, double defense, int accuracy, int expGain, Relic? relic = null) : base(name, hp, attack, defense, accuracy)
        {
            ExpGain = expGain;           
            if (relic != null)
            {
                Relic = relic;               
            }
        }
    }
}
