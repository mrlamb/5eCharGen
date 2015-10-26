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
    class Lang
    {
        private Dictionary<string, string> Localization { get; set; }
        private static Lang instance;

        private Lang(Languages lang)
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            string filename = Directory.GetCurrentDirectory() + "\\Languages\\" + lang + ".json";

            if (File.Exists(filename))
            {
                dictionary = JsonConvert.DeserializeObject<Dictionary<string, string>>(File.ReadAllText(filename));
            }
            else
            {
                MessageBox.Show("Localization Data not found");
            }

            Localization = dictionary;
        }

        internal string Get(string v)
        {
            try
            {
                return Localization[v];
            }
            catch (KeyNotFoundException)
            {
                return "Missing localization";
            }
        }

        public static Lang GetInstance()
        {
            if (instance == null)
                instance = new Lang(Languages.English);

            return instance;
        }
    }

    enum Languages
    {
        English, Spanish
    }
}
