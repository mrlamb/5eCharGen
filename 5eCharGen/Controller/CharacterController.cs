using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5eCharGen.Controller
{
    class CharacterController : ICharacter
    {
        public Character Character { get; set; }

        public string Name
        {
            get
            {
                return Character.Name;
            }

            set
            {
                Character.Name = value;
            }
        }

        public int CharLevel
        {
            get
            {
                return Character.CharLevel;
            }

            set
            {
                Character.CharLevel = value;
            }
        }

        public IList<CharClass> Classes
        {
            get
            {
                return Character.Classes;
            }

            set
            {
                Character.Classes = value as List<CharClass>;
            }
        }

        public Race Race
        {
            get
            {
                return Character.Race;
            }

            set
            {
                Character.Race = value;
            }
        }

        public IDictionary<string, int> Attributes
        {
            get
            {
                return Character.Attributes;
            }

            set
            {
                Character.Attributes = value as Dictionary<string, int>;
            }
        }

        public IList<Skills> Skills
        {
            get
            {
                return Character.Skills;
            }

            set
            {
                Character.Skills = value as List<Skills>;
            }
        }

        public IList<Feats> Feats
        {
            get
            {
                return Character.Feats as IList<Feats>;
            }

            set
            {
                Character.Feats = value as List<Feats>;
            }
        }

        public CharacterController()
        {
            if (Character == null)
                Character = new Character();
        }

        public CharacterController(Character character)
        {
            Character = character;
        }

        
    }
}
