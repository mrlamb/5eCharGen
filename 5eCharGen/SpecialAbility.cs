using Newtonsoft.Json;
using System.Collections.Generic;

namespace _5eCharGen
{
    public class SpecialAbility
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Dictionary<string, int> AttributeBonus { get; set; }
        //Thought to use a string list for added spells, then go through
        //Data.GetSpells adding to the Character object the actual spells from 
        //this list
        public List<string> SpellsAdded { get; set; }

        public SpecialAbility()
        {
            AttributeBonus = new Dictionary<string, int>();
            SpellsAdded = new List<string>();
        }
    }

    public class SpecialAbilities
    {
        public List<SpecialAbility> Values { get; set; }
    }
}