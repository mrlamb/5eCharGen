using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5eCharGen.Model
{
    static class ProgramOptions
    {
        public static Dictionary<string, string> OptionsTable { get; set; }

        static ProgramOptions()
        {
            var dictionary = new Dictionary<string, string>();
            string filename = Directory.GetCurrentDirectory() + "\\options.json";
            if(File.Exists(filename))
            {
                dictionary = JsonConvert.DeserializeObject<Dictionary<string, string>>(File.ReadAllText(filename));

                
            }

            OptionsTable = dictionary;
        }

        public static string GetOption(string v)
        {
            if (OptionsTable.ContainsKey(v))
            {
                return OptionsTable[v];
            }
            else
            {
                return null;
            }
        }

    }
}
