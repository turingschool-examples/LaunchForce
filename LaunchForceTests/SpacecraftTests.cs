using LaunchForce;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaunchForceTests
{
    public class SpacecraftTests
    {
        [Fact]
        public void Spacecraft_Cosntructor_CorrectlySetsPropertyValues()
        {
            var millenniumfalcon = new Spacecraft("Millennium Falcon", 2000);

            Assert.Equal("Millennium Falcon", millenniumfalcon.Name);
            Assert.Equal(2000, millenniumfalcon.Fuel);
        }
    }
}
