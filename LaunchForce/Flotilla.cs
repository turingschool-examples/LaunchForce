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
        public void AddShip(Spacecraft ship)
        {
            Ships.Add(ship);
        }
        public List<string> Roster()
        {
            var returnList = new List<string>();
            foreach (Spacecraft ship in Ships)
            {
                returnList.AddRange(ship.Roster());
            }
            return returnList;
        }
        public Dictionary<Spacecraft, List<Person>> ShipSummary()
        {
            var returnDict = new Dictionary<Spacecraft, List<Person>>();
            foreach (Spacecraft ship in Ships)
            {
                returnDict.Add(ship, ship.Personnel);
            }
            return returnDict;
        }
    }
}
