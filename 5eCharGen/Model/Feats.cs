namespace _5eCharGen
{
    public class Feat : SpecialAbility
    {
        public Prerequisite Prereq { get; set; }

        public Feat() : base()
        {
            
        }
    
        public override string ToString()
        {
            return Name;
        }
    }
}