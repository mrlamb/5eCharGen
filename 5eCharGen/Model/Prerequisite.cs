using _5eCharGen.View.Localization;
using System;
using System.Collections.Generic;
using System.Text;

namespace _5eCharGen
{
    public class Prerequisite
    {
        public float CasterLevel { get; set; }
        public Dictionary<string, int> Stats { get; set; }
        public bool AnyStatApplies { get; set; }
        public List<string> Proficiencies { get; set; }
        public bool HasSpells { get; set; }
        public int CharacterLevel { get; set; }
        public Dictionary<string, int> ClassLevels { get; set; }

        public Prerequisite()
        {
            Stats = new Dictionary<string, int>();
            Proficiencies = new List<string>();
            ClassLevels = new Dictionary<string, int>();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            if (CasterLevel != 0)
            {
                sb.AppendFormat(Language.GetLocalizedString(""), CasterLevel.ToString());
            }

            foreach (KeyValuePair<string, int> pair in Stats)
            {
                if (pair.Value != 0)
                {
                    sb.AppendFormat(Language.GetLocalizedString(""), pair.Key, pair.Value);
                }
                if (AnyStatApplies)
                {
                    sb.Append(" or ");
                }
            }
            if (Proficiencies.Count == 0)
            {
                sb.AppendFormat(Language.GetLocalizedString(""));
            }
            foreach (string prof in Proficiencies)
            {
                sb.Append(prof + " ");
            }

            if (HasSpells)
            {
                sb.Append(Language.GetLocalizedString(""));
            }

            if (CharacterLevel != 0)
            {
                sb.AppendFormat(Language.GetLocalizedString(""));
            }

            foreach(KeyValuePair<string, int> pair in ClassLevels)
            {
                sb.AppendFormat(Language.GetLocalizedString(""), pair.Key, pair.Value);
            }

            return sb.ToString();
        }
    }
}