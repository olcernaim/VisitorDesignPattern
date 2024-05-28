using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vis2
{
    public class ComputerPartDisplayVisitor : ComputerPartVisitor
    {

        public void visit(Computer computer)
        {
            Console.WriteLine("Displaying Computer.");
        }

        public void visit(Mouse mouse)
        {
            Console.WriteLine("Displaying Mouse.");
        }

        public void visit(Keyboard keyboard)
        {
            Console.WriteLine("Displaying Keyboard.");
        }

        public void visit(Monitor monitor)
        {
            Console.WriteLine("Displaying Monitor.");
        }
    }
}
