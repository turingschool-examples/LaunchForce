using LaunchForce;

namespace LaunchForceTests
{
    public class PersonTests
    {
        [Fact]
        public void Person_Constructor_AssignsValuesCorrectly()
        {
            var person1 = new Person("Skylar Sandler", 3);

            Assert.Equal("Skylar Sandler", person1.Name);
            Assert.Equal(3, person1.Experience);
        }

        [Fact]
        public void Person_AddSpeciality_CorrectlyAddsSpecialitytoPerson()
        {
            var person1 = new Person("Skylar Sandler", 3);

            person1.AddSpeciality("flight");
            person1.AddSpeciality("star reading");

            Assert.Equal("flight", person1.Specialties[0]);
            Assert.Equal("star reading", person1.Specialties[1]);
        }
    }
}