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
            var returnList = new List<string>();
            foreach (Person person in Personnel)
            {
                returnList.Add(person.Name);
            }
            return returnList;
        }
        public int TotalExperience()
        {
            int returnInt = 0;
            foreach (Person person in Personnel)
            {
                returnInt += person.Experience;
            }
            return returnInt;
        }
        public double AverageExperience()
        {
            double sum = Convert.ToDouble(TotalExperience());
            double count = Convert.ToDouble(Roster().Count);
            double returnDouble = sum / count;

            return returnDouble;
        }
    }
}
