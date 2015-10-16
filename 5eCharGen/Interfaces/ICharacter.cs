using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5eCharGen
{
    public interface ICharacter
    {
        string Name { get; set; }
        int CharLevel { get; set; }
        IList<CharClass> Classes { get; set; }
        Race Race { get; set; }
        IDictionary<string, int> Attributes { get; set; }
        IList<Skills> Skills { get; set; }
        IList<Skills> Feats { get; set; }
        //Inventory Inventory { get; set; }
    }
}
