using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaunchForce
{
    public class Spacecraft
    {
        public string Name { get; private set; }
        public int Fuel { get; private set; }
        public List<Person> Personnel { get; private set; }

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
            var roster = new List<string>();

            foreach (var person in Personnel)
            {
                roster.Add(person.Name);
            }

            return roster;
        }
    }
}
