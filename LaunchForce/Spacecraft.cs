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

        public void AddPerson(Person person)
        {
            Personnel.Add(person);
        }

        public List<string> Roster()
        {
            List<string> roster = new List<string>();
            foreach(var person in Personnel)
            {
                roster.Add(person.Name);
            }
            return roster;
        }

        public int TotalExperience()
        {
            int exp = 0;
            foreach(var person in Personnel)
            {
                exp += person.Experience;
            }
            return exp;
        }

        public double AverageExperience()
        {
            double exp = 0;
            foreach (var person in Personnel)
            {
                exp += person.Experience;
            }
            exp = exp / Personnel.Count;
            return exp;
        }
    }
}
