using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vis2
{
    public class Computer : ComputerPart
    {

        ComputerPart[]
        parts;

        public Computer()
        {
            parts = new ComputerPart[] { new Mouse(), new Keyboard(), new Monitor() };
        }


        public void accept(ComputerPartVisitor computerPartVisitor)
        {
            for (int i = 0; i < parts.Length; i++)
            {
                parts[i].accept(computerPartVisitor);
            }
            computerPartVisitor.visit(this);
        }
    }
}
