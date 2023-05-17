namespace LaunchForce.Test
{
    public class SpacecraftTests
    {
        [Fact]
        public void Constructor_TakesTwoArguments()
        {
            Spacecraft daedalus = new Spacecraft("Daedalus", 400);

            Assert.Equal("Daedalus", daedalus.Name);
            Assert.Equal(400, daedalus.Fuel);
            Assert.Equal(new List<Person>(), daedalus.Personnel);
        }

        [Fact]
        public void AddPersonnel_UpdatesListOfPersonnel()
        {
            Spacecraft daedalus = new Spacecraft("Daedalus", 400);
            Person kathy = new Person("Kathy Chan", 10);
            Person megan = new Person("Megan McMahon", 2);

            daedalus.AddPersonnel(megan);
            daedalus.AddPersonnel(kathy);

            var expected = new List<Person> { megan, kathy };

            Assert.Equal(expected, daedalus.Personnel);
        }

        [Fact]
        public void Roster_ReturnsNamesOfAllPersonnel()
        {
            Spacecraft daedalus = new Spacecraft("Daedalus", 400);
            Person kathy = new Person("Kathy Chan", 10);
            Person megan = new Person("Megan McMahon", 2);

            daedalus.AddPersonnel(megan);
            daedalus.AddPersonnel(kathy);

            var expected = new List<string> { megan.Name, kathy.Name };

            Assert.Equal(expected, daedalus.Roster());
        }
    }
}