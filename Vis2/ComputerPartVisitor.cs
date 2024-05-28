using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vis2
{
	public interface ComputerPartVisitor
	{
		public void visit(Computer computer);
		public void visit(Mouse mouse);
		public void visit(Keyboard keyboard);
		public void visit(Monitor monitor);
	}
}
