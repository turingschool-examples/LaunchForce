using LaunchForce;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests
{
    public class SpaceCraftTest
    {
        [Fact]
        public void Test_SpaceCraft_Constructor()
        {
            SpaceCraft daedalus = new SpaceCraft("Daedalus", 400);

            Assert.NotNull(daedalus);
            Assert.Equal("Daedalus", daedalus.Name);
            Assert.Equal(400, daedalus.Fuel);
        }

        [Fact]
        public void Test_SpaceCraft_AddPersonnel()
        {
            Person kathy = new Person("Kathy Chan", 10);
            SpaceCraft daedalus = new SpaceCraft("Daedalus", 400);

            daedalus.AddPersonnel(kathy);

            Assert.Equal(new List<Person> { kathy }, daedalus.Personnel);
        }

        [Fact]
        public void Test_SpaceCraft_Roster()
        {
            Person kathy = new Person("Kathy Chan", 10);
            Person Joe = new Person("Joe Cen", 5);

            SpaceCraft daedalus = new SpaceCraft("Daedalus", 400);

            daedalus.AddPersonnel(kathy);
            daedalus.AddPersonnel(Joe);

            Assert.Equal(new List<string> { "Kathy Chan", "Joe Cen" }, daedalus.Roster());
        }

        [Fact]
        public void Test_SpaceCraft_TotalExperience()
        {
            Person kathy = new Person("Kathy Chan", 10);
            Person Joe = new Person("Joe Cen", 5);

            SpaceCraft daedalus = new SpaceCraft("Daedalus", 400);

            daedalus.AddPersonnel(kathy);
            daedalus.AddPersonnel(Joe);

            Assert.Equal(15, daedalus.TotalExperience());
        }

        [Fact]
        public void Test_SpaceCraft_AverageExperience()
        {
            Person kathy = new Person("Kathy Chan", 10);
            Person Joe = new Person("Joe Cen", 5);

            SpaceCraft daedalus = new SpaceCraft("Daedalus", 400);

            daedalus.AddPersonnel(kathy);
            daedalus.AddPersonnel(Joe);

            Assert.Equal(7.5, daedalus.AverageExperience());
        }
    }
}
