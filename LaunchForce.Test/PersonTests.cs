namespace LaunchForce.Test
{
    public class PersonTests
    {
        [Fact]
        public void Constructor_TakesTwoArguments()
        {
            Person kathy = new Person("Kathy Chan", 10);

            Assert.Equal("Kathy Chan", kathy.Name);
            Assert.Equal(10, kathy.Experience);
            Assert.Equal(new List<string>(), kathy.Specialties);
        }

        [Fact]
        public void AddSpecialty_UpdatesListOfSpecialties()
        {
            Person kathy = new Person("Kathy Chan", 10);
            kathy.AddSpecialty("engineering");
            kathy.AddSpecialty("navigation");

            var expected = new List<string> { "engineering", "navigation" };

            Assert.Equal(expected, kathy.Specialties);
        }
    }
}