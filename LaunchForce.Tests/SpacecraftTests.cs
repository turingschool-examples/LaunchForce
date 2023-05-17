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
        }
    }
}