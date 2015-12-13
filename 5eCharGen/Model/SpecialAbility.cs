using Newtonsoft.Json;
using System.Collections.Generic;
using System.Text;

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
        public string SpeedIncrease { get; set; }
        public Dictionary<string, string> ProficienciesAltered { get; set; }
        
        public SpecialAbility()
        {
            AttributeBonus = new Dictionary<string, int>();
            SpellsAdded = new List<string>();
            ProficienciesAdded = new List<string>();
            ProficienciesAltered = new Dictionary<string, string>();
        }

        public override string ToString()
        {
            return Name;
        }

        public string GetSummary()
        {
            var sb = new StringBuilder();
            var usedAttributes = new Dictionary<string, int>();
            foreach (var pair in AttributeBonus)
            {
                if (pair.Value > 0)
                {
                    usedAttributes.Add(pair.Key, pair.Value);
                }
            }

            if (usedAttributes.Count > 0)
            {
                sb.Append("Attributes changed: ");
            }

            foreach (var pair in usedAttributes)
            {
                sb.Append(pair.Key + ": " + pair.Value + "\n\r");
            }

            if (SpellsAdded.Count > 0)
            {
                sb.Append("Spells added: ");
                for (int i = 0, length = SpellsAdded.Count; i < length; i++)
                {
                    if (length -1 == i)
                    {
                        sb.Append(SpellsAdded[i] + "\n\r");
                    }
                    else
                    {
                        sb.Append(SpellsAdded[i] + ", ");
                    }
                }
            }

            if (ProficienciesAdded.Count > 0)
            {
                sb.Append("Proficiencies added: ");
                for (int i = 0, length = ProficienciesAdded.Count; i < length; i++)
                {
                    if (length - 1 == i)
                    {
                        sb.Append(ProficienciesAdded[i] + "\n\r");
                    }
                    else
                    {
                        sb.Append(ProficienciesAdded[i] + ", ");
                    }
                }
            }

            if (ProficienciesAltered.Count > 0)
            {
                sb.Append("Proficiencies altered: ");
                foreach(var pair in ProficienciesAltered)
                {
                    sb.Append(pair.Key + ": " + pair.Value);
                }
            }

            if (!ACBonus.Equals(""))
            {
                sb.Append("AC Bonus: " + ACBonus + "\n\r");
            }

            if (!SpeedIncrease.Equals(""))
            {
                sb.Append("Speed Bonus: " + SpeedIncrease + "\n\r");
            }

            return sb.ToString();
        }

    }

   
}