using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaunchForce.Tests
{
    public class SpaceCraftTests
    {

        [Fact]
        public void SpaceCraft_Properties_Created()
        {
            SpaceCraft craft1 = new SpaceCraft("ship", 250);

            Assert.Equal("ship", craft1.Name);
            Assert.Equal(250, craft1.Fuel);
        }

        [Fact]
        public void addPersonelAddsPersontoList()
        {
            Person person1 = new Person("brad", 100);
            SpaceCraft craft1 = new SpaceCraft("ship", 250);

            craft1.AddPersonnel(person1);

            Assert.Equal("brad", craft1.Personnel[0].Name);
        }

        [Fact]
        public void RosterMethodReturnsFullRoster()
        {
            Person person1 = new Person("brad", 100);
            Person person2 = new Person("Pitt", 100);

            SpaceCraft craft1 = new SpaceCraft("ship", 250);

            craft1.AddPersonnel(person1);
            craft1.AddPersonnel(person2);

            List<string> roster = craft1.Roster();

            Assert.Equal(roster, new List<string> { "brad", "Pitt" });

        }

        [Fact]
        public void TotalXP_ReturnsCrewsTotalXP()

        {
            Person person1 = new Person("brad", 100);
            Person person2 = new Person("Pitt", 100);

            SpaceCraft craft1 = new SpaceCraft("ship", 250);

            craft1.AddPersonnel(person1);
            craft1.AddPersonnel(person2);

            int totalXP = craft1.TotalXP();

            Assert.Equal(200, totalXP);

        }

        [Fact]
        public void AverageXp_returnsAVGXP_acrossCrew()
        {
            Person person1 = new Person("brad", 100);
            Person person2 = new Person("Pitt", 100);

            SpaceCraft craft1 = new SpaceCraft("ship", 250);

            craft1.AddPersonnel(person1);
            craft1.AddPersonnel(person2);

            double avgXP= craft1.averageXP();

            Assert.Equal(100, avgXP);
        }

    }  
}
