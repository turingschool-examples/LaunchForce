using LaunchForce;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaunchForceTests
{
    public class SpacecraftTests
    {
        [Fact]
        public void Spacecraft_Cosntructor_CorrectlySetsPropertyValues()
        {
            var millenniumfalcon = new Spacecraft("Millennium Falcon", 2000);

            Assert.Equal("Millennium Falcon", millenniumfalcon.Name);
            Assert.Equal(2000, millenniumfalcon.Fuel);
            Assert.Equal(new List<Person>(), millenniumfalcon.Personnel);
        }

        [Fact]
        public void Spacecraft_AddPersonnel_AddPersontoPersonnel()
        {
            var millenniumfalcon = new Spacecraft("Millennium Falcon", 2000);
            var person1 = new Person("Skylar Sandler", 3);
            var person2 = new Person("Scott Ganz", 5);

            millenniumfalcon.AddPersonnel(person1);
            millenniumfalcon.AddPersonnel(person2);

            Assert.Equal(person1, millenniumfalcon.Personnel[0]);
            Assert.Equal(person2, millenniumfalcon.Personnel[1]);
        }

        //[Fact]
        //public void Spacecraft_Roster_ReturnsPersonnelList()
        //{
        //    var millenniumfalcon = new Spacecraft("Millennium Falcon", 2000);
        //    var person1 = new Person("Skylar Sandler", 3);
        //    var person2 = new Person("Scott Ganz", 5);

        //    millenniumfalcon.AddPersonnel(person1);
        //    millenniumfalcon.AddPersonnel(person2);

        //    var allPersonnel = new List<string>();

        //    foreach (Person person in millenniumfalcon.Personnel)
        //    {
        //        allPersonnel.Add(Person.Name);
        //    }

        //    var personnelList = millenniumfalcon.Roster();

        //    Assert.Equal(allPersonnel, personnelList);
        //}

        [Fact]
        public void Spacecraft_TotalExperince_CorrectlyTotalsPersonnelExperience()
        {
            var millenniumfalcon = new Spacecraft("Millennium Falcon", 2000);
            var person1 = new Person("Skylar Sandler", 3);
            var person2 = new Person("Scott Ganz", 5);

            millenniumfalcon.AddPersonnel(person1);
            millenniumfalcon.AddPersonnel(person2);

            Assert.Equal(8, millenniumfalcon.TotalExperience());
        }

        [Fact]
        public void Spacecraft_AverageExperience_CorrectlyReturnsAverage()
        {
            var millenniumfalcon = new Spacecraft("Millennium Falcon", 2000);
            var person1 = new Person("Skylar Sandler", 3);
            var person2 = new Person("Scott Ganz", 7);

            millenniumfalcon.AddPersonnel(person1);
            millenniumfalcon.AddPersonnel(person2);

            Assert.Equal(5, millenniumfalcon.AverageExperience());
        }
    }
}
