using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaunchForce
{
    public class Spacecraft
    {
        public string Name;
        public int Fuel;

        public Spacecraft(string name, int fuel)
        {
            Name = name;
            Fuel = fuel;
        }
    }
}
