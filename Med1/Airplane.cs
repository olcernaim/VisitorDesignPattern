using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Med1
{
	// Colleague Interface
	public interface Airplane
	{
		void requestTakeoff();
		void requestLanding();
		void notifyAirTrafficControl(String message);
	}
}
