namespace LaunchForce.Testing
{
    public class PersonTests
    {
        [Fact]
        public void Person_Constructor_InstantiatesPersonObject()
        {
            Person person1 = new Person("name", 100);

            Assert.Equal("name", person1.Name);
            Assert.Equal(100, person1.Experience);
            Assert.Equal(new List<string>(), person1.Specialties);
        }

        [Fact]
        public void Person_AddSpecialty_AddsToSpecialtiesListProperty()
        {
            Person person1 = new Person("name", 100);

            person1.AddSpecialty("Brave");

            Assert.Equal("Brave", person1.Specialties[0]);
        }
    }
}