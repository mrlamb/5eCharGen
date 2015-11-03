using _5eCharGen.Model;

namespace _5eCharGen
{
    public class Proficiency : IDataType
    {
        public string Name { get; set; }
        public bool Learned { get; set; }
        public ProfType Type { get; set; }
        public bool Expertise { get; set; }
        public NotationType DerivedStat { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }

   
}

namespace _5eCharGen.Model
{
    public enum ProfType
    {
        Weapon, Armor, Skill, Tool
    }
}