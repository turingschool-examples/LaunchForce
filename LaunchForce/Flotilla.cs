using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaunchForce
{
    public class Flotilla
    {
        public List<SpaceCraft> Ships;
        public Flotilla()
        {
            Ships = new List<SpaceCraft>();
        }

        public void AddShip(SpaceCraft shipToAdd)
        {
            Ships.Add(shipToAdd);
        }

        public List<string> Roster()
        {
            List<string> tempList = new List<string>();

            foreach (var spaceShip in Ships)
            {
                foreach (var person in spaceShip.Personnel)
                {
                    tempList.Add(person.Name);
                }
            }

            return tempList;
        }
        public Dictionary<SpaceCraft, List<Person>> ShipSummary()
        {
            Dictionary<SpaceCraft, List<Person>> tempShipSummary = new Dictionary<SpaceCraft, List<Person>>();

            foreach (var spaceShip in Ships)
            {
                tempShipSummary.Add(spaceShip, spaceShip.Personnel);
            }

            return tempShipSummary;
        }
    }
}
