using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaunchForce.Testing
{
    public class SpacecraftTests
    {
        [Fact]
        public void Spacecraft_Constructor_InstantiatesSpacecraftObject()
        {
            Spacecraft daedalus = new Spacecraft("Daedalus", 400);

            Assert.Equal("Daedalus", daedalus.Name);
            Assert.Equal(400, daedalus.Fuel);
        }
    }
}
