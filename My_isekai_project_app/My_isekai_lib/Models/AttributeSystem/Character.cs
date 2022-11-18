using My_isekai_lib.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace My_isekai_lib.Models.AttributeSystem
{
    public class Character
    {
        #region Class Members
        public string Name { get; set; }
        public double HpTotal { get; set; }
        public double HpCurrent { get; set; }
        public double Attack { get; set; }
        public double Defense { get; set; }
        public int Accuracy { get; set; }
        public int Level { get; set; }
        public int ExpTotal { get; set; }
        public int ExpCurrent { get; set; }
        public bool Weapon { get; set; } = false;
        public bool Armor { get; set; } = false;
        public bool Relic { get; set; } = false; 
        #endregion

        public Character() { }

        public Character(string name, double hp, double attack, double defense, int accuracy)
		{
			Name = name;
			HpTotal = hp;
            HpCurrent = HpTotal;
            Attack = attack;
			Defense = defense;
            Accuracy = accuracy;

            Level = 1;
            ExpCurrent = 0;
            ExpTotal = 100;
        }

        /// <summary>
        /// Method used to attack on both sides
        /// </summary>
        /// <param name="damage"></param>
        /// <param name="accuracy"></param>
        /// <returns></returns>
        public string TakeDamage(double damage, double defense, int accuracy)
        {
            string infoOutput = "";
            double critMod = 1;

            int roll = Randomizer.Dice(1, 21);     
            
            if (roll >= (20 - accuracy))
            {
                if (roll == 20)
                {
                    critMod = 2;
                    infoOutput += Environment.NewLine + " - Mega Critical hit!";
                }

                if (roll >= 18 && roll < 20)
                {
                    critMod = 1.5;
                    infoOutput += Environment.NewLine + " - Critical hit!";
                }

                double result = (damage * critMod) - defense;
                if (result > 0)
                {
                    HpCurrent -= result;
                    infoOutput += Environment.NewLine + "Damage = " + result;
                }
                else
                {
                    infoOutput += Environment.NewLine + "Damage = 0";
                }                
            }
            else
            {
                infoOutput += Environment.NewLine + " - Attack was dodged...";
            }

            return infoOutput;
        }

        /// <summary>
        /// Use to regenerate and mostly to test the game
        /// </summary>
        /// <returns></returns>
        public string Regenerate()
        {
            if (HpCurrent < HpTotal)
            {
                HpCurrent += 50;
                if (HpCurrent > HpTotal)
                {
                    HpCurrent = HpTotal;
                }
                return "You have just recovered 50 HP!";
            }
            else
            {
                return "Don't be greedy... you are already full...";
            }
        }

        /// <summary>
        /// When expCurrent = 100, you level up
        /// </summary>
        public void LevelUp()
        {          
            HpTotal += 20;
            HpCurrent = HpTotal;
            Attack += 3;
            Defense += 5;
            Accuracy += 1;

            Level++;
        }
    }
}
