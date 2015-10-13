using System.Collections.Generic;

namespace _5eCharGen
{
    public class Race
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public List<SpecialAbility> RacialAbilities { get; set; }
        public Dictionary<string, int> RacialStatChange { get; set; }


    }

    public class Races
    {
        public List<Race> Values { get; set; }
    }
}