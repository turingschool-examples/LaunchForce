using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaunchForce
{
    public class Spacecraft
    {
        string Name;
        int Fuel;
        List<Person> Personnel;
        public Spacecraft(string name, int fuel)
        {
            Name = name;
            Fuel = fuel;
            List<Person> Personnel = new List<Person>();
        }

        public void AddPersonnel(Person person)
        {
            Personnel.Add(person);
        }

        public List<Person> Roster()
        {
            return Personnel.GetRange(0, Personnel.Count);
        }

        public int TotalExperience()
        {
            int TotalXP = 0;
            foreach (Person person in Personnel)
            {
                
               TotalXP += person.Experience;
            }
            return TotalXP;
        }

        public double AverageExperience()
        {
            int TotalXP = 0;
            foreach (Person person in Personnel)
            {

                TotalXP += person.Experience;
            }
            double averageExperience = TotalXP / Personnel.Count;
            return averageExperience;

        }
    }
}
