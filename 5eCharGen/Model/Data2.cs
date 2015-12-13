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
            if (proficiencies.ContainsKey(name))
            {
                return proficiencies[name];
            }
            else
            {
                return null;
            }

        }

        internal static void AddProficiency(Proficiency pf)
        {
            if (proficiencies.ContainsKey(pf.Name))
            {
                proficiencies.Remove(pf.Name);
            }
            proficiencies.Add(pf.Name, pf);
            Save<Proficiency>(proficiencies);
            updateIndexes();
        }

        internal static void RemoveProficiency(string name)
        {
            if (proficiencies.ContainsKey(name))
            {
                proficiencies.Remove(name);
                Save<Proficiency>(proficiencies);
                updateIndexes();
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

        internal static void AddRace(Race newRace)
        {
            if (races.ContainsKey(newRace.Name))
            {
                races.Remove(newRace.Name);
            }
            races.Add(newRace.Name, newRace);
            Save<Race>(races);
            updateIndexes();

        }

        internal static void RemoveRace(string name)
        {
            if (races.ContainsKey(name))
            {
                races.Remove(name);
                Save<Race>(races);
                updateIndexes();
            }
        }

        //Special abilities
        internal static IEnumerable<SpecialAbility> GetAllSAs()
        {
            return specialAbilities.Values;
        }

        internal static SpecialAbility GetSA(string name)
        {
            return specialAbilities[name];
        }

        internal static void AddSA(SpecialAbility sa)
        {
            if (specialAbilities.ContainsKey(sa.Name))
            {
                specialAbilities.Remove(sa.Name);
            }
            specialAbilities.Add(sa.Name, sa);
            Save<SpecialAbility>(specialAbilities);
            updateIndexes();
        }

        internal static void RemoveSA(string name)
        {
            if (specialAbilities.ContainsKey(name))
            {
                specialAbilities.Remove(name);
                Save<SpecialAbility>(specialAbilities);
                updateIndexes();
            }
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
            if (spells.ContainsKey(spell.Name))
            {
                spells.Remove(spell.Name);
            }
            spells.Add(spell.Name, spell);
            Save<Spell>(spells);
            updateIndexes();
        }

        internal static void RemoveSpell(string name)
        {
            if (spells.ContainsKey(name))
            {
                spells.Remove(name);
                Save<Spell>(spells);
                updateIndexes();
            }
        }


    }
}
