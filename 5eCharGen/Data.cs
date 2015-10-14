using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace _5eCharGen
{
    public static class Data
    {
        private static Dictionary<string, Race> races = new Dictionary<string, Race>();

        static Data()
        {
            races = Load<Race>();
        }

        private static Dictionary<string, T> Load<T>(string dataPath = "/Data") where T : IDataType
        {
            Dictionary<string, T> dictionary = new Dictionary<string, T>();
            string filename = Directory.GetCurrentDirectory() + dataPath + "/" + typeof(T).Name + ".json";
            if (File.Exists(filename))
            {
                T[] dataArray = JsonConvert.DeserializeObject<T[]>(File.ReadAllText(filename));
                foreach (T data in dataArray)
                {
                    dictionary.Add(data.Name, data);
                }
            }
            return dictionary;
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