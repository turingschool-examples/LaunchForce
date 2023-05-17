using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaunchForce.Tests
{
    public class FlotillaTests
    {
        [Fact]
        public void Flotilla_Constructor_InitializesPropertyValues()
        {
            Flotilla flotilla = new Flotilla();

            Assert.Equal(new List<Spacecraft>(), flotilla.Ships);
        }

        [Fact]
        public void Flotilla_AddShip_AddsShipToShips()
        {
            Flotilla flotilla = new Flotilla();
            Spacecraft daedalus = new Spacecraft("Daedalus", 400);

            flotilla.AddShip(daedalus);

            Assert.Equal(daedalus, flotilla.Ships[0]);
        }

        [Fact]
        public void Flotilla_Roster_ReturnsStringListOfAllPersonnelNamesFromShips()
        {
            Flotilla flotilla = new Flotilla();

            Person kathy = new Person("Kathy Chan", 10);
            Person seth = new Person("Seth Grinstead", 15);
            Spacecraft daedalus = new Spacecraft("Daedalus", 400);

            daedalus.AddPerson(kathy);
            daedalus.AddPerson(seth);

            Person john = new Person("John Spacepilot", 3);
            Spacecraft serenity = new Spacecraft("Serenity", 150);

            serenity.AddPerson(john);

            flotilla.AddShip(serenity);
            flotilla.AddShip(daedalus);

            List<string> roster = flotilla.Roster();
            
            Assert.Equal(3, roster.Count);
            Assert.Equal("Seth Grinstead", roster[2]);
        }

        [Fact]
        public void Flotilla_ShipSummary_ReturnsDictionaryOfShipInfo()
        {
            Flotilla flotilla = new Flotilla();

            Person kathy = new Person("Kathy Chan", 10);
            Person seth = new Person("Seth Grinstead", 15);
            Spacecraft daedalus = new Spacecraft("Daedalus", 400);

            daedalus.AddPerson(kathy);
            daedalus.AddPerson(seth);

            Person john = new Person("John Spacepilot", 3);
            Spacecraft serenity = new Spacecraft("Serenity", 150);

            serenity.AddPerson(john);

            flotilla.AddShip(serenity);
            flotilla.AddShip(daedalus);

            Dictionary<Spacecraft, List<Person>> summary = flotilla.ShipSummary();
            Assert.Equal(2, summary.Count);
            Assert.Equal(summary[serenity][0].Name, "John Spacepilot");
        }
    }
}
