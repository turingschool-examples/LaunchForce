using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaunchForce
{
    public class Flotilla
    {
        public string Name;
        public List<Spacecraft> Ships;

        public Flotilla(string name)
        {
            Name = name;
            Ships = new List<Spacecraft>();
        }

        public void AddShip(Spacecraft ship)
        {
            Ships.Add(ship);
        }

        public List<string> Roster()
        {
            var personnelNames = new List<string>();
            foreach (var Person in Personnel)
            {
                personnelNames.Add(Person.Name);
            }
            return personnelNames;
        }
    }
}
