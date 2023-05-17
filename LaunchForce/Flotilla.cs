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
            List<string> AllPersonnel = new List<string>();
            foreach(Spacecraft ship in Ships)
            {
                foreach(Person person in ship.Personnel)
                {
                    AllPersonnel.Add(person.Name);
                }
            }
            return AllPersonnel;
        }
        public Dictionary<Spacecraft, List<Person>> ShipSummary()
        {
            Dictionary<Spacecraft, List<Person>> ShipsAndPersonnel = new Dictionary<Spacecraft, List<Person>>();
            foreach(Spacecraft ship in Ships)
            {
                ShipsAndPersonnel.Add(ship, ship.Personnel);
            }
            return ShipsAndPersonnel;
        }
           
    }
}
