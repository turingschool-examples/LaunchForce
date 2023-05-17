using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaunchForce
{
    public class Person
    {
        public string Name { get; private set; }
        public int Experience { get; private set; }
        public List<string> Specialties { get; private set; }

        public Person(string name, int experience)
        {
            Name = name;
            Experience = experience;
            Specialties = new List<string>();
        }

        public void AddSpecialty(string specialty)
        {
            Specialties.Add(specialty);
        }
    }
}
