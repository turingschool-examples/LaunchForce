using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaunchForce
{
    public class Flotilla
    {
        public List<Spacecraft> Ships;

        public Flotilla()
        {
            Ships = new List<Spacecraft>();
        }

        public void AddShip(Spacecraft spacecraft)
        {
            Ships.Add(spacecraft);
        }

        public List<string> Roster()
        {
            List<string> roster = new List<string>();
            foreach(var ship in Ships)
            {
                roster.AddRange(ship.Roster());
            }
            return roster;
        }

        public Dictionary<Spacecraft, List<Person>> ShipSummary()
        {
            var summary = new Dictionary<Spacecraft, List<Person>>();
            foreach(var ship in Ships)
            {
                summary.Add(ship, ship.Personnel);
            }
            return summary;
        }
    }
}
