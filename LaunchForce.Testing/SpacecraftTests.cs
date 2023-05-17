using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaunchForce.Testing
{
    public class SpacecraftTests
    {
        [Fact]
        public void Spacecraft_Constructor_InstantiatesSpacecraftObject()
        {
            Spacecraft daedalus = new Spacecraft("Daedalus", 400);

            Assert.Equal("Daedalus", daedalus.Name);
            Assert.Equal(400, daedalus.Fuel);
        }

        [Fact]
        public void Spacecraft_AddPersonnel_AddsPersonnelToList()
        {
            Spacecraft daedalus = new Spacecraft("Daedalus", 400);
            Person test1 = new Person("test1", 100);
            Person test2 = new Person("test2", 100);
            Person test3 = new Person("test3", 100);

            daedalus.AddPersonnel(test1);
            daedalus.AddPersonnel(test2);
            daedalus.AddPersonnel(test3);

            Assert.Equal("test1", daedalus.Personnel[0].Name);
            Assert.Equal("test2", daedalus.Personnel[1].Name);
            Assert.Equal("test3", daedalus.Personnel[2].Name);
        }

        [Fact]
        public void Spacecraft_Roster_ReturnsStringListOfPersonnel()
        {
            Spacecraft daedalus = new Spacecraft("Daedalus", 400);
            Person test1 = new Person("test1", 100);
            Person test2 = new Person("test2", 100);
            Person test3 = new Person("test3", 100);

            daedalus.AddPersonnel(test1);
            daedalus.AddPersonnel(test2);
            daedalus.AddPersonnel(test3);

            var nameList = new List<string>();
            nameList = daedalus.Roster();

            Assert.Equal("test1", nameList[0]);
            Assert.Equal("test2", nameList[1]);
            Assert.Equal("test3", nameList[2]);
        }
        [Fact]
        public void Spacecraft_TotalExperience_IntTotalExperienceOfRoster()
        {
            Spacecraft daedalus = new Spacecraft("Daedalus", 400);
            Person test1 = new Person("test1", 100);
            Person test2 = new Person("test2", 200);
            Person test3 = new Person("test3", 300);
            
            daedalus.AddPersonnel(test1);
            daedalus.AddPersonnel(test2);
            daedalus.AddPersonnel(test3);

            int totalExperience = daedalus.TotalExperience();

            Assert.Equal(600, totalExperience);
        }
        [Fact]
        public void Spacecraft_AverageExperience_ReturnsDoubleOfAverageRosterExperience()
        {
            Spacecraft daedalus = new Spacecraft("Daedalus", 400);
            Person test1 = new Person("test1", 100);
            Person test2 = new Person("test2", 200);
            Person test3 = new Person("test3", 300);

            daedalus.AddPersonnel(test1);
            daedalus.AddPersonnel(test2);
            daedalus.AddPersonnel(test3);

            double avgExperience = daedalus.AverageExperience();

            Assert.Equal(200, avgExperience);

        }
    }
}
