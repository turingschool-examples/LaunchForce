namespace LaunchForce.Tests
{
    public class PersonTests
    {
        [Fact]
        public void Person_Constructor_InitializesPropertyValues()
        {
            Person kathy = new Person("Kathy Chan", 10);

            Assert.Equal("Kathy Chan", kathy.Name);
            Assert.Equal(10, kathy.Experience);
            Assert.Equal(new List<string>(), kathy.Specialties);
        }
    }
}