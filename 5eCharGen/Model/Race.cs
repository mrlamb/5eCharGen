using System.Collections.Generic;

namespace _5eCharGen
{
    public class Race : IDataType
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public List<string> RacialAbilities { get; set; }
        public Dictionary<string, int> RacialStatChange { get; set; }
        public int Speed { get; set; }
        public List<string> Languages { get; set; }
        public bool Subrace { get; set; }
        public string ParentRace { get; set; }

        public Race()
        {
            RacialStatChange = new Dictionary<string, int> {
                {"STR", 0 },
                {"DEX", 0 },
                {"CON", 0 },
                {"INT", 0 },
                {"WIS", 0 },
                {"CHA", 0 }
            };
            Languages = new List<string>();
            RacialAbilities = new List<string>();
        }

        public override string ToString()
        {
            return Name;
        }

        
    }



}