using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaunchForce
{
    public class Person
    {
        string Name;
        int Experience;
        List<string> Specialties;

        public Person(string name, int experience)
        {
            Name = name;
            Experience = experience;
            List<string> specialties = new List<string>();
        }

        public void AddSpecialty(string specialty)
        {
            Specialties.Add(specialty);
        }
    }
}
