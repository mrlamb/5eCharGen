using _5eCharGen.View;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace _5eCharGen
{
    public static class Data
    {
        private static Dictionary<string, Race> races = new Dictionary<string, Race>();
        private static Dictionary<string, Feats> feats = new Dictionary<string, Feats>();
        private static Dictionary<string, Spell> spells = new Dictionary<string, Spell>();

        private static ConsoleLog log = new ConsoleLog();
        static Data()
        {

            log.Show();
            races = Load<Race>();
            feats = Load<Feats>();
            spells = Load<Spell>();
        }

        private static Dictionary<string, T> Load<T>(string dataPath = "\\Data") where T : IDataType
        {
            Dictionary<string, T> dictionary = new Dictionary<string, T>();
            string filename = Directory.GetCurrentDirectory() + dataPath + "\\" + typeof(T).Name + ".json";
            log.Add(string.Format("Loading file: {0}\n\r", filename));

            if (File.Exists(filename))
            {
                T[] dataArray = JsonConvert.DeserializeObject<T[]>(File.ReadAllText(filename));

                foreach (T data in dataArray)
                {
                    log.Add(string.Format("Adding new {0} - {1}\n\r", typeof(T).Name, data.Name));
                    dictionary.Add(data.Name, data);
                }
            }
            return dictionary;
        }

        internal static IEnumerable<Spell> GetAllSpells()
        {
            return spells.Values;
        }

        public static Spell GetSpell(string name)
        {
            return spells[name];
        }

        public static IEnumerable<Race> GetAllRaces()
        {
            return races.Values;
        }

        public static Race GetRace(string name)
        {
            return races[name];
        }

    }
}