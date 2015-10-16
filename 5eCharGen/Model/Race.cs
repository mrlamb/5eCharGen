using System.Collections.Generic;

namespace _5eCharGen
{
    public class Race : IDataType
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public List<SpecialAbility> RacialAbilities { get; set; }
        public Dictionary<string, int> RacialStatChange { get; set; }
        public int Speed { get; set; }
        public List<string> Languages { get; set; }
        public bool Subrace { get; set; }
        public string ParentRace { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }



}