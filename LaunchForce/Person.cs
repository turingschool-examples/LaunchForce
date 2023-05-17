using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaunchForce
{
    public class Person
    {
        public string Name;
        public int Experience;
        public List<string> Specialties;

        public Person(string name, int xp)
        {
            Name = name;
            Experience = xp;
            Specialties = new List<string>();
        }

        public void AddSpecialty(string specialty)
        {
            Specialties.Add(specialty);
        }
    }
}
