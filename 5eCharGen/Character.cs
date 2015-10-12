using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5eCharGen
{
    class Character
    {
        public string Name { get; set; }
        public int CharLevel { get; set; }
        public List<CharClass> Classes { get; set; }
        public Race Race { get; set; }
        public Dictionary<string, int> Attributes { get; set; }
        public List<Skills> Skills { get; set; }
        public List<Feats> Feats { get; set; }
        public Inventory Inventory { get; set; }

        public Character(StreamReader sr)
        {
            // Load character data from the file
            
        }





    }
}
