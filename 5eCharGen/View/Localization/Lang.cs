using _5eCharGen.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5eCharGen.View.Localization
{
    public static class Language
    {
        public static Dictionary<string, string> Localization { get; set; }
        
        static Language()
        {
            string lang = ProgramOptions.GetOption("LANGUAGE");

            Dictionary<string, string> dictionary = new Dictionary<string, string>();

            if (lang != null)
            {
                
                string filename = Directory.GetCurrentDirectory() + "\\Languages\\" + lang + ".json";

                if (File.Exists(filename))
                {
                    dictionary = JsonConvert.DeserializeObject<Dictionary<string, string>>(File.ReadAllText(filename));
                }
                else
                {
                    MessageBox.Show("Localization Data not found");

                }
            }
            Localization = dictionary;

        }

        public static string GetLocalizedString(string v)
        {
           if (Localization.ContainsKey(v))
           {
                return Localization[v];
           }
           else
           {
               return "Missing localization";
           }


        }
    }
}
