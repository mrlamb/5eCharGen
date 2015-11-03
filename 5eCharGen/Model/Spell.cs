using System.Collections.Generic;

namespace _5eCharGen
{
    public class Spell : IDataType
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public int School { get; set; }
        public Dictionary<string, bool> Components { get; set; }
        public string MaterialDescription { get; set; }
        public string CastTimeFrontPortion { get; set; }
        public int CastTimeAction { get; set; }
        public string Range { get; set; }
        public string Duration { get; set; }
        public string Description { get; set; }
        public bool Ritual { get; set; }
        

        public Spell()
        {
            Components = new Dictionary<string, bool>();
            Components.Add("Verbal", false);
            Components.Add("Somatic", false);
            Components.Add("Material", false);

            MaterialDescription = string.Empty;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}