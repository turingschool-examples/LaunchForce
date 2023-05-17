using LaunchForce;

namespace UnitTests
{
    public class PersonTest
    {
        [Fact]
        public void Test_Person_Constructor()
        {
            Person kathy = new Person("Kathy Chan", 10);

            Assert.NotNull(kathy);
            Assert.Equal("Kathy Chan", kathy.Name);
            Assert.Equal(10, kathy.Experience);
        }

        [Fact]
        public void Test_Person_AddSpecialty()
        {
            Person kathy = new Person("Kathy Chan", 10);

            kathy.AddSpecialty("Coding in C#");
            Assert.Equal(new List<string> { "Coding in C#" }, kathy.Specialties);
        }
    }
}