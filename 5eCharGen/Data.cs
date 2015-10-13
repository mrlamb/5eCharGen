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
                if (obj is Races)
                {
                    //Need to iterate through obj and add each to new 
                    //races queue
                    Races Races = (Races)obj;
                    foreach (Race race in Races.Values)
                    {
                        races.Enqueue(race);
                    }
                }

            }

            return races;
        }
    }
}