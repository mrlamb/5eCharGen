using System;
using System.Collections.Generic;

namespace _5eCharGen
{
    internal class Data
    {
        private List<Object> data = new List<object>();

        internal void Add(object v)
        {
            data.Add(v);
        }

        public Queue<Race> GetRaces()
        {
            Queue<Race> races = new Queue<Race>();
            foreach (Object obj in data)
            {
                switch (string.Format("{0}", obj.GetType()))
                {
                    case "_5eCharGen.Races":
                        //Need to iterate through obj and add each to new 
                        //races queue
                        
                        break;
                }

            }

            return races;
        }
    }
}