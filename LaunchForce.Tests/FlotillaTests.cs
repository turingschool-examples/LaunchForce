namespace LaunchForce.Tests
{
    public class FlotillaTests
    {
        [Fact]
        public void Flotilla_Constructor_CreatesFlotillaObject()
        {
            var testFlotilla = new Flotilla();

            Assert.IsType<Spacecraft>(testFlotilla.Ships);
            Assert.Empty(testFlotilla.Ships);
        }
        [Fact]
        public void Flotilla_AddShip_AddsSpacefraftToShips()
        {
            var testFlotilla = new Flotilla();
            string name = "Serenity";
            int fuel = 400;
            var spacecraft = new Spacecraft(name, fuel);
            testFlotilla.AddShip(spacecraft);
            Assert.Single(testFlotilla.Ships);
            Assert.Equal(spacecraft, testFlotilla.Ships[0]);
        }
        [Fact]
        public void Flotilla_Roster_ReturnsListOfAllPersonsOnAllShips()
        {
            var testFlotilla = new Flotilla();
            string name = "Serenity";
            int fuel = 400;
            var spacecraft1 = new Spacecraft(name, fuel);
            name = "Endurance";
            fuel = 200;
            var spacecraft2 = new Spacecraft(name, fuel);
            string personName = "Jack White";
            int xp = 10;
            var person1 = new Person(personName, xp);
            personName = "Peyton Watson";
            xp = 8;
            var person2 = new Person(personName, xp);
            spacecraft1.AddPersonnel(person1);
            spacecraft1.AddPersonnel(person2);
            personName = "Jeff Green";
            xp = 32;
            var person3 = new Person(personName, xp);
            personName = "Ish Smith";
            xp = 14;
            var person4 = new Person(personName, xp);
            spacecraft2.AddPersonnel(person3);
            spacecraft2.AddPersonnel(person4);
            testFlotilla.AddShip(spacecraft1);
            testFlotilla.AddShip(spacecraft2);

            var expected = new List<Person>() { person1, person2, person3, person4 };
            Assert.Equal(expected, testFlotilla.Roster());
        }
        [Fact]
        public void Flotilla_ShipSummary_ReturnsDictionaryOfEachShipAndItsRoster()
        {
            var testFlotilla = new Flotilla();
            string name = "Serenity";
            int fuel = 400;
            var spacecraft1 = new Spacecraft(name, fuel);
            name = "Endurance";
            fuel = 200;
            var spacecraft2 = new Spacecraft(name, fuel);
            string personName = "Jack White";
            int xp = 10;
            var person1 = new Person(personName, xp);
            personName = "Peyton Watson";
            xp = 8;
            var person2 = new Person(personName, xp);
            spacecraft1.AddPersonnel(person1);
            spacecraft1.AddPersonnel(person2);
            personName = "Jeff Green";
            xp = 32;
            var person3 = new Person(personName, xp);
            personName = "Ish Smith";
            xp = 14;
            var person4 = new Person(personName, xp);
            spacecraft2.AddPersonnel(person3);
            spacecraft2.AddPersonnel(person4);
            testFlotilla.AddShip(spacecraft1);
            testFlotilla.AddShip(spacecraft2);
            var expected = new Dictionary<Spacecraft, List<Person>>()
            {
                {spacecraft1, new List<Person>(){person1, person2} },
                {spacecraft2, new List<Person>(){person3, person4} }
            };
            Assert.Equal(expected, testFlotilla.ShipSummary());
        }
    }
}