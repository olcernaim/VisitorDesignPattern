using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vis2
{
    public class Keyboard : ComputerPart
    {

        public void accept(ComputerPartVisitor computerPartVisitor)
        {
            computerPartVisitor.visit(this);
        }
    }
}
