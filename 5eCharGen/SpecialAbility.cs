using Newtonsoft.Json;
using System.Collections.Generic;

namespace _5eCharGen
{
    public class SpecialAbility
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Dictionary<string, int> AttributeBonus { get; set; }

        public SpecialAbility()
        {
            AttributeBonus = new Dictionary<string, int>();
        }
    }
}