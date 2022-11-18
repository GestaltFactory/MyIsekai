using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_isekai_lib.Models.AttributeSystem
{
    public class Weapon
    {
        public string Name { get; set; }    
        public string Description { get; set; }
        public double Power { get; set; }

        public Weapon(string name, string description, double power)
        {
            Name = name;
            Description = description;
            Power = power;
        }
    }
}
