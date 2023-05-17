using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaunchForce.Testing
{
    public class FlotillaTesting
    {
        [Fact]
        public void Flotilla_Constructor_InstantiatesFlotillaObject()
        {
            Flotilla flotilla = new Flotilla();

            Assert.Equal(new List<Spacecraft>(), flotilla.Ships);
        }

        [Fact]
        public void Flotilla_AddShip_AddsSpaceshipToShipsListProperty()
        {
            Flotilla flotilla = new Flotilla();
            Spacecraft daedalus = new Spacecraft("Daedalus", 400);

            flotilla.AddShip(daedalus);

            Assert.Equal("Daedalus", flotilla.Ships[0].Name);
        }

        [Fact]
        public void Flotilla_Roster_ReturnsStringListOfAllPersonnal()
        {
            Flotilla flotilla = new Flotilla();
            Spacecraft daedalus = new Spacecraft("Daedalus", 400);
            Spacecraft daedalusMk2 = new Spacecraft("Daedalus", 400);
            Person test1 = new Person("test1", 100);
            Person test2 = new Person("test2", 200);
            Person test3 = new Person("test3", 300);
            Person test21 = new Person("test21", 100);
            Person test22 = new Person("test22", 200);
            Person test23 = new Person("test23", 300);
            daedalus.AddPersonnel(test1);
            daedalus.AddPersonnel(test2);
            daedalus.AddPersonnel(test3);
            daedalusMk2.AddPersonnel(test21);
            daedalusMk2.AddPersonnel(test22);
            daedalusMk2.AddPersonnel(test23);
            flotilla.AddShip(daedalus);
            flotilla.AddShip(daedalusMk2);

            var roster = flotilla.Roster();
            var bothRosters = daedalus.Roster();
            bothRosters.AddRange(daedalusMk2.Roster());

            Assert.IsType<List<string>>(roster);
            Assert.Equal(bothRosters, roster);
        }

        [Fact]
        public void Flotilla_ShipSummary_ReturnsDictionaryOfShipsAndPersonnelLists()
        {
            Flotilla flotilla = new Flotilla();
            Spacecraft daedalus = new Spacecraft("Daedalus", 400);
            Spacecraft daedalusMk2 = new Spacecraft("Daedalus", 400);
            Person test1 = new Person("test1", 100);
            Person test2 = new Person("test2", 200);
            Person test3 = new Person("test3", 300);
            Person test21 = new Person("test21", 100);
            Person test22 = new Person("test22", 200);
            Person test23 = new Person("test23", 300);
            daedalus.AddPersonnel(test1);
            daedalus.AddPersonnel(test2);
            daedalus.AddPersonnel(test3);
            daedalusMk2.AddPersonnel(test21);
            daedalusMk2.AddPersonnel(test22);
            daedalusMk2.AddPersonnel(test23);
            flotilla.AddShip(daedalus);
            flotilla.AddShip(daedalusMk2);

            Dictionary<Spacecraft, List<Person>> ShipsSummary = 
                                            new Dictionary<Spacecraft, List<Person>>();
            ShipsSummary = flotilla.ShipSummary();

            Assert.IsType<Dictionary<Spacecraft, List<Person>>>(ShipsSummary);
            Assert.True(ShipsSummary.ContainsKey(daedalus));
            Assert.True(ShipsSummary.ContainsKey(daedalusMk2));
            Assert.True(ShipsSummary.ContainsValue(daedalus.Personnel));
            Assert.True(ShipsSummary.ContainsValue(daedalusMk2.Personnel));
        }
    }
}
