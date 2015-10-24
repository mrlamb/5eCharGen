using Newtonsoft.Json;
using System.Collections.Generic;

namespace _5eCharGen
{
    public class SpecialAbility : IDataType
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public Dictionary<string, int> AttributeBonus { get; set; }
        public List<string> SpellsAdded { get; set; }
        public List<string> ProficienciesAdded { get; set; }
        public string ACBonus { get; set; }
        public int SpeedIncrease { get; set; }
        



        public SpecialAbility()
        {
            AttributeBonus = new Dictionary<string, int>();
            SpellsAdded = new List<string>();
        }


    }

   
}