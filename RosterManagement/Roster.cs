using System;
using System.Linq;
using System.Collections.Generic;

namespace RosterManagement
{
    public class CodeSchool
    {
        Dictionary<int, List<string>> _roster;

        public CodeSchool()
        {
            _roster = new Dictionary<int, List<String>>();
        }
        
        /// <summary>
        /// Should be able to Add Student to a Particular Wave
        /// </summary>
        /// <param name="cadet">Refers to the name of the Cadet</param>
        /// <param name="wave">Refers to the Wave number</param>
        public void Add(string cadet, int wave)
        {
            List<string> wave_cadet = new List<string>();
            wave_cadet = Grade(wave);
            wave_cadet.Add(cadet);
            _roster[wave] = wave_cadet;

        }

        /// <summary>
        /// Returns all the Cadets in a given wave
        /// </summary>
        /// <param name="wave">Refers to the wave number from where cadet list is to be fetched</param>
        /// <returns>List of Cadet's Name</returns>
        public List<string> Grade(int wave)
        {
            var list = new List<string>();
            if (_roster.ContainsKey(wave))
            {
                list = _roster[wave];
            }
            list.Sort();
            return list;
        }

        /// <summary>
        /// Return all the cadets in the CodeSchool
        /// </summary>
        /// <returns>List of Cadet's Name</returns>
        public List<string> Roster()
        {
            var cadets = new List<string>();
            var keys = new List<int>();
            foreach(int key in _roster.Keys)
            {
                keys.Add(key);
            }
            keys.Sort();
            foreach(int key in keys)
            {
                foreach (string cadet in Grade(key))
                {
                    cadets.Add(cadet);
                    cadets.OrderBy(p => p);
                }
                
            }
            return cadets;
        }
    }
}
