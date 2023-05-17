using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaunchForce.Tests
{
    public class SpacecraftTests
    {
        [Fact]
        public void Spacecraft_Constructor_InitializesPropertyValues()
        {
            Spacecraft daedalus = new Spacecraft("Daedalus", 400);

            Assert.Equal("Daedalus", daedalus.Name);
            Assert.Equal(400, daedalus.Fuel);
            Assert.Equal(new List<Person>(), daedalus.Personnel);
        }

        [Fact]
        public void Spacecraft_AddPerson_AddsPersonToPersonnel()
        {
            Person kathy = new Person("Kathy Chan", 10);
            Spacecraft daedalus = new Spacecraft("Daedalus", 400);

            daedalus.AddPerson(kathy);

            Assert.Equal(daedalus.Personnel[0], kathy);
        }

        [Fact]
        public void Spacecraft_Roster_ReturnsStringListOfPersonnelNames()
        {
            Person kathy = new Person("Kathy Chan", 10);
            Person seth = new Person("Seth Grinstead", 15);
            Spacecraft daedalus = new Spacecraft("Daedalus", 400);

            daedalus.AddPerson(kathy);
            daedalus.AddPerson(seth);

            List<string> roster = daedalus.Roster();

            Assert.Equal("Kathy Chan", roster[0]);
            Assert.Equal("Seth Grinstead", roster[1]);
        }

        [Fact]
        public void SpaceCraft_TotalExperience_ReturnsCombinedExperienceOfAllPersonnel()
        {
            Person kathy = new Person("Kathy Chan", 10);
            Person seth = new Person("Seth Grinstead", 15);
            Spacecraft daedalus = new Spacecraft("Daedalus", 400);

            daedalus.AddPerson(kathy);
            daedalus.AddPerson(seth);

            Assert.Equal(25, daedalus.TotalExperience());
        }

        [Fact]
        public void Spacecraft_AverageExperience_ReturnsAvgExperienceOfAllPersonnnel()
        {
            Person kathy = new Person("Kathy Chan", 10);
            Person seth = new Person("Seth Grinstead", 15);
            Spacecraft daedalus = new Spacecraft("Daedalus", 400);

            daedalus.AddPerson(kathy);
            daedalus.AddPerson(seth);

            Assert.Equal(12.5, daedalus.AverageExperience());
        }
    }
}
