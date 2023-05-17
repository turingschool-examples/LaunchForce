using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaunchForce
{
    public class SpaceCraft
    {
        public string Name;
        public int Fuel;
        public List<Person> Personnel;
        public SpaceCraft(string name, int fuel) 
        {
            Name = name;
            Fuel = fuel;
            Personnel = new List<Person>();
        }

        public void AddPersonnel(Person personToAdd) 
        {
            Personnel.Add(personToAdd);
        }

        public List<string> Roster () 
        {
            List<string> tempList = new List<string>();

            foreach (var person in Personnel)
            {
                tempList.Add(person.Name);
            }

            return tempList;
        }

        public int TotalExperience()
        {
            int totalExp = 0;

            foreach (var person in Personnel)
            {
                totalExp += person.Experience;
            }

            return totalExp;
        }

        public int AverageExperience()
        {
            int totalExp = 0;

            foreach (var person in Personnel)
            {
                totalExp += person.Experience;
            }

            return totalExp / Personnel.Count;
        }
    }
}
