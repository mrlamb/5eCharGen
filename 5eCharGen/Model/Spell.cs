using System.Collections.Generic;

namespace _5eCharGen
{
    public class Spell : IDataType
    {
        public string Name { get; set; }
        public string Level { get; set; }
        public string School { get; set; }
        public Dictionary<string, bool> Components { get; set; }
        public string MaterialDescription { get; set; }
        public string CastTimeFrontPortion { get; set; }
        public string CastTimeAction { get; set; }
        public string Range { get; set; }
        public string Duration { get; set; }
        public string[] Description { get; set; }
        

        public Spell()
        {
            Components = new Dictionary<string, bool>();
            Components.Add("Verbal", false);
            Components.Add("Somatic", false);
            Components.Add("Material", false);

            MaterialDescription = string.Empty;
        }
    }
}