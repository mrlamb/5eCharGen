﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5eCharGen
{
    public class Character
    {
        public string Name { get; set; }
        public int CharLevel { get; set; }
        public List<CharClass> Classes { get; set; }
        public Race Race { get; set; }
        public Dictionary<string, int> Attributes { get; set; }
        public List<Skills> Skills { get; set; }
        public List<Feats> Feats { get; set; }
        public Inventory Inventory { get; set; }

        public Character()
        {
            Attributes = new Dictionary<string, int>()
            {
                {"STR", 8 },
                {"DEX", 8 },
                {"CON", 8 },
                {"WIS", 8 },
                {"INT", 8 },
                {"CHA", 8 }
            };
        }

        public Character(StreamReader sr)
        {
            // Load character data from the file
            
        }





    }
}
