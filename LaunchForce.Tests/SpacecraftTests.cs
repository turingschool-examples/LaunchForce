namespace LaunchForce.Tests
{
    public class SpacecraftTests
    {
        [Fact]
        public void Spececraft_Constructor_CreatesNewSpaceshipObject()
        {
            string name = "Serenity";
            int fuel = 400;
            var testSpacecraft = new Spacecraft(name, fuel);

            Assert.Equal(name, testSpacecraft.Name);
            Assert.Equal(fuel, testSpacecraft.Fuel);
            Assert.IsType<List<Person>>(testSpacecraft.Personnel);
            Assert.Empty(testSpacecraft.Personnel);
        }
        [Fact]
        public void Spacecraft_AddPersonnel_AddsPersonToPersonnel()
        {
            string name = "Serenity";
            int fuel = 400;
            var testSpacecraft = new Spacecraft(name, fuel);
            string personName = "Jack White";
            int xp = 10;
            var person = new Person(personName, xp);
            testSpacecraft.AddPersonnel(person);
            Assert.Single(testSpacecraft.Personnel);
            Assert.Equal(person, testSpacecraft.Personnel[0]);
        }
        [Fact]
        public void Spacecraft_Roster_ReturnsAllPersonsInPersonnel()
        {
            string name = "Serenity";
            int fuel = 400;
            var testSpacecraft = new Spacecraft(name, fuel);
            string personName = "Jack White";
            int xp = 10;
            var person1 = new Person(personName, xp);
            personName = "Peyton Watson";
            xp = 8;
            var person2 = new Person(personName, xp);
            testSpacecraft.AddPersonnel(person1);
            testSpacecraft.AddPersonnel(person2);
            var expected = new List<Person>() { person1, person2 };
            Assert.Equal(expected, testSpacecraft.Roster());
        }
        [Fact]
        public void Spacecraft_TotalExperience_ReturnsSumOfExperienceForEachPerson()
        {
            string name = "Serenity";
            int fuel = 400;
            var testSpacecraft = new Spacecraft(name, fuel);
            string personName = "Jack White";
            int xp = 10;
            var person1 = new Person(personName, xp);
            personName = "Peyton Watson";
            xp = 8;
            var person2 = new Person(personName, xp);
            testSpacecraft.AddPersonnel(person1);
            testSpacecraft.AddPersonnel(person2);
            int expected = 18;
            Assert.Equal(expected, testSpacecraft.TotalExperience());
        }
        [Fact]
        public void Spacecraft_AverageExperience_ReturnsSumOfExperienceForEachPerson()
        {
            string name = "Serenity";
            int fuel = 400;
            var testSpacecraft = new Spacecraft(name, fuel);
            string personName = "Jack White";
            int xp = 10;
            var person1 = new Person(personName, xp);
            personName = "Peyton Watson";
            xp = 8;
            var person2 = new Person(personName, xp);
            testSpacecraft.AddPersonnel(person1);
            testSpacecraft.AddPersonnel(person2);
            double expected = 9;
            Assert.Equal(expected, testSpacecraft.AverageExperience());
        }
    }
}