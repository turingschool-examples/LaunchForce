using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

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

        public void AddPersonnel(Person person)
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

        public int TotalXP()
        {
            int TotalXP = 0;

            foreach (var person in Personnel)
            {
                TotalXP += person.Experience;
            }

            return TotalXP;
        }

        public double averageXP()
        {
            double averageXP = 0;

            foreach(var person in Personnel)
            {
                averageXP += person.Exoerience;
            }
            averageXP = averageXP / Personnel.Count;

            return averageXP;
        }

    }
}
