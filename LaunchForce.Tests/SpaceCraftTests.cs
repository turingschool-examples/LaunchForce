using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaunchForce.Tests
{
    public class SpaceCraftTests
    {

        [Fact]
        public void SpaceCraft_Properties_Created()
        {
            SpaceCraft craft1 = new SpaceCraft("ship", 250);

            Assert.Equal("ship", craft1.Name);
            Assert.Equal(250, craft1.Fuel);
        }

    }
}
