using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaunchForce
{
    public class Spacecraft
    {
        public string Name;
        public int Fuel;
        public List<Person> Personnel;

        public Spacecraft(string name, int fuel)
        {
            Name = name;
            Fuel = fuel;
            Personnel = new List<Person>();
        }

        public void AddPersonnel(Person person)
        {
            Personnel.Add(person);
        }

        public List<string> Roster()
        {
            List<string> nameList = new List<string>();

            foreach(Person person in Personnel)
            {
                nameList.Add(person.Name);
            }
            return nameList;
        }

        public int TotalExperience()
        {
            int totalExperience = 0;

            foreach (Person person in Personnel)
            {
                totalExperience += person.Experience;
            }
            return totalExperience;
        }

        public double AverageExperience()
        {
            int totalExperience = 0;
            double avgExperience = 0D;

            foreach (Person person in Personnel)
            {
                totalExperience += person.Experience;
            }
            avgExperience = totalExperience / Personnel.Count;
            return avgExperience;
        }
    }
}
