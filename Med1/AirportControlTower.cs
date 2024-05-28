using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Med1
{
    // Concrete Mediator
    public class AirportControlTower : AirTrafficControlTower
    {
        public void requestTakeoff(Airplane airplane)
        {
            // Logic for coordinating takeoff
            airplane.notifyAirTrafficControl("Requesting takeoff clearance.");
        }
        public void requestLanding(Airplane airplane)
        {
            // Logic for coordinating landing
            airplane.notifyAirTrafficControl("Requesting landing clearance.");
        }
    }
}
