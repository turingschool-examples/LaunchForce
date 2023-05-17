using System;

namespace LaunchForce.Tests
{
    public class PersonTests
    {
        [Fact]
        public void Person_Constructor_CreatesPersonObject()
        {
            string name = "Jack White";
            int xp = 10;
            var testPerson = new Person(name, xp);

            Assert.Equal(name, testPerson.Name);
            Assert.Equal(xp, testPerson.Experience);
            Assert.IsType<List<string>>(testPerson.Specialties);
            Assert.Empty(testPerson.Specialities);
        }
        [Fact]
        public void Person_AddSpecialty_AddsStringToSpecialities()
        {
            string name = "Jack White";
            int xp = 10;
            var testPerson = new Person(name, xp);
            string speciality = "Rebounding";
            testPerson.AddSpeciality(speciality);

            Assert.Single(testPerson.Specialities);
            Assert.Equal(speciality, testPerson.Specialities[0]);
        }
    }
}