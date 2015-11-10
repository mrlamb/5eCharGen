using _5eCharGen.View;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

//This file is responsible for setting up the data constructs and handling loading and saving of the parts to file
// See file Data2.cs for individual type based methods

namespace _5eCharGen
{
    public static partial class Data
    {
        private static Dictionary<string, Race> races = new Dictionary<string, Race>();
        private static Dictionary<string, Feat> feats = new Dictionary<string, Feat>();

        private static Dictionary<string, Spell> spells = new Dictionary<string, Spell>();
        private static Dictionary<string, Proficiency> proficiencies = new Dictionary<string, Proficiency>();

        private static Dictionary<string, SpecialAbility> specialAbilities = new Dictionary<string, SpecialAbility>();

        private static ConsoleLog log = new ConsoleLog();
        static Data()
        {

            log.Show();
            races = Load<Race>();
            feats = Load<Feat>();
            spells = Load<Spell>();
            proficiencies = Load<Proficiency>();
            specialAbilities = Load<SpecialAbility>();
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

        private static void Save<T>(Dictionary<string, T> data, string dataPath = "\\Data")
        {
            string filename = Directory.GetCurrentDirectory() + dataPath + "\\" + typeof(T).Name + ".json";

            List<T> Out = new List<T>();
            foreach(KeyValuePair<string, T> pair in data)
            {
                Out.Add(pair.Value);
            }         
            using (StreamWriter sw = new StreamWriter(filename))
            {
                sw.Write(JsonConvert.SerializeObject(Out, Formatting.Indented));
                
            }
        }

        

    }
}