using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

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
            var personnelNames = new List<string>();
            foreach (var Person in Personnel)
            {
                personnelNames.Add(Person.Name);
            }
            return personnelNames;
        }

        public int TotalExperience()
        {
            var total = 0;
            foreach (var Person in Personnel)
            {
                total += Person.Experience;
            }
            return total;
        }

        public double AverageExperience()
        {
            var personnelExperience = new List<int>();
            foreach(var Person in Personnel)
            {
                personnelExperience.Add(Person.Experience);
            }
            double avgExperience = Queryable.Average(personnelExperience.AsQueryable());
            return avgExperience;
        }

    }
}
