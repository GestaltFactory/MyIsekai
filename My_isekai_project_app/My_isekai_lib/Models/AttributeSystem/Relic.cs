using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_isekai_lib.Models.AttributeSystem
{
    public class Relic
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Attribute { get; set; }

        public Relic(string name, string description, int attribute)
        {
            Name = name;
            Description = description;
            Attribute = attribute;
        }
    }
}
