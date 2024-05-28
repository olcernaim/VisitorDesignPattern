using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Med1
{
	// Mediator Interface
	public interface AirTrafficControlTower
	{
		void requestTakeoff(Airplane airplane);
		void requestLanding(Airplane airplane);
	}
}
