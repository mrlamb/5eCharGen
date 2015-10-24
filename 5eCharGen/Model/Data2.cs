using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//This file contains all the individual type methods
// Split from Data.cs just for readability.

namespace _5eCharGen
{
    public static partial class Data
    {
        //Proficiencies
        internal static IEnumerable<Proficiency> GetAllProficiencies()
        {
            return proficiencies.Values;
        }

        internal static Proficiency GetProficiency(string name)
        {
            return proficiencies[name];
        }

        internal static void AddProficiency(Proficiency pf)
        {
            proficiencies.Add(pf.Name, pf);
            Save<Proficiency>(proficiencies);
        }

        internal static void RemoveProficiency(string name)
        {
            if (proficiencies.ContainsKey(name))
            {
                proficiencies.Remove(name);
                Save<Proficiency>(proficiencies);
            }
        }

        //Races
        internal static IEnumerable<Race> GetAllRaces()
        {
            return races.Values;
        }

        internal static Race GetRace(string name)
        {
            return races[name];
        }


        //Spells
        internal static IEnumerable<Spell> GetAllSpells()
        {
            return spells.Values;
        }

        internal static Spell GetSpell(string name)
        {
            return spells[name];
        }

        internal static void AddSpell(Spell spell)
        {
            spells.Add(spell.Name, spell);
            Save<Spell>(spells);
        }

        internal static void RemoveSpell(string name)
        {
            if (spells.ContainsKey(name))
            {
                spells.Remove(name);
                Save<Spell>(spells);
            }
        }
    }
}
