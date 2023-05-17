using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaunchForce.Tests
{
    public class PersonTests
    {
        [Fact]
        public void Check_PersonProperties_Created()
        {
            Person person1 = new Person("brad", 100);

            Assert.Equal("brad", person1.Name);
            Assert.Equal(100, person1.Experience);
            Assert.Equal(new List<string>(), person1.Skills);
        }

        [Fact]
        public void AddSkillToListOfSkills()
        {
            Person person1 = new Person("brad", 100);
            
            person1.AddSkill("spaceflight");

            Assert.Equal("spaceflight", person1.Skills[0]);
        }
    }
}
