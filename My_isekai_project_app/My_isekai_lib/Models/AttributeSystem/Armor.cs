using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_isekai_lib.Models.AttributeSystem
{
    public class Armor
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public double Resistance { get; set; }

        public Armor(string name, string description, double resistance)
        {
            Name = name;
            Description = description;
            Resistance = resistance;
        }
    }
}
