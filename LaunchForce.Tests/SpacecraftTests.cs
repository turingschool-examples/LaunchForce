using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaunchForce.Tests
{
    public class SpacecraftTests
    {
        [Fact]
        public void Spacecraft_Constructor_InitializesPropertyValues()
        {
            Spacecraft daedalus = new Spacecraft("Daedalus", 400);

            Assert.Equal("Daedalus", daedalus.Name);
            Assert.Equal(400, daedalus.Fuel);
        }
    }
}
