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

        public Person(string name, int experience)
        {
            Name = name;
            Experience = experience;
            Specialties = new List<string>();
        }

        public void AddSpeciality(string speciality)
        {
            Specialties.Add(speciality);
        }
    }
}
