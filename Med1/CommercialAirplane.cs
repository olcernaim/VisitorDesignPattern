using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Med1
{
    // Concrete Colleague
    public class CommercialAirplane : Airplane
    {
        private AirTrafficControlTower mediator;

        public CommercialAirplane(AirTrafficControlTower mediator)
        {
            this.mediator = mediator;
        }
        public void requestTakeoff()
        {
            mediator.requestTakeoff(this);
        }
        public void requestLanding()
        {
            mediator.requestLanding(this);
        }
        public void notifyAirTrafficControl(String message)
        {
            Console.WriteLine("Commercial Airplane: " + message);
        }
    }
}
