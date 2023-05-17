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
        public List<string> Skills;

        public Person(string name, int experience)
        {
            Name = name;
            Experience = experience;
            Skills = new List<string>();
        }

        public void AddSkill(string skill)
        {
            Skills.Add(skill);
        }

    }
}
