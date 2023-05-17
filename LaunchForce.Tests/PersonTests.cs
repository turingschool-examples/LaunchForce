namespace LaunchForce.Tests
{
    public class PersonTests
    {
        [Fact]
        public void Person_Constructor_InitializesPropertyValues()
        {
            Person person = new Person("Kathy Chan", 10);

            Assert.Equal("Kathy Chan", person.Name);
            Assert.Equal(10, person.Experience);
            Assert.Equal(new List<string>(), person.Specialties);
        }
    }
}