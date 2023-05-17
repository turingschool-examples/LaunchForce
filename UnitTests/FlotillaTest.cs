using LaunchForce;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests
{
    public class FlotillaTest
    {
        [Fact]
        public void Test_Flotilla_Constructor()
        {
            Flotilla flotilla = new Flotilla();

            Assert.NotNull(flotilla);
            Assert.Empty(flotilla.Ships);
        }

        [Fact]
        public void Test_Flotilla_AddShip()
        {
            Flotilla flotilla = new Flotilla();
            SpaceCraft daedalus = new SpaceCraft("Daedalus", 400);

            flotilla.AddShip(daedalus);

            Assert.NotEmpty(flotilla.Ships);
        }

        [Fact]
        public void Test_Flotilla_Roster()
        {
            Flotilla flotilla = new Flotilla();
            SpaceCraft daedalus = new SpaceCraft("Daedalus", 400);
            SpaceCraft daedalusTwo = new SpaceCraft("DaedalusTWO", 400);

            Person kathy = new Person("Kathy Chan", 10);
            Person Joe = new Person("Joe Cen", 5);

            Person kathyTheSecond = new Person("Kathy Chan", 10);
            Person JoeTheSecond = new Person("Joe Cen", 5);

            flotilla.AddShip(daedalus);
            flotilla.AddShip(daedalusTwo);
            daedalus.AddPersonnel(kathy);
            daedalus.AddPersonnel(Joe);
            daedalusTwo.AddPersonnel(kathyTheSecond);
            daedalusTwo.AddPersonnel(JoeTheSecond);

            Assert.Equal(new List<string> { "Kathy Chan", "Joe Cen", "Kathy Chan", "Joe Cen" }, flotilla.Roster());
        }

        // Ran out of time to make last test for Ship Summary
    }
}
