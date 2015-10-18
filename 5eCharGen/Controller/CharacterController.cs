using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5eCharGen.Controller
{
    public class CharacterController : ICharacter
    {
        public string Name { get; set; }
        public int CharLevel { get; set; }
        public IList<CharClass> Classes { get; set; }
        public Race Race { get; set; }
        public IDictionary<string, int> Attributes { get; set; }
        public IList<Skills> Skills { get; set; }
        public IList<Feats> Feats { get; set; }
        //public Inventory Inventory { get; set; }




    }
}
