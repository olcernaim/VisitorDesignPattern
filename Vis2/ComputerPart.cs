using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vis2
{
    public interface ComputerPart
    {
        public void accept(ComputerPartVisitor computerPartVisitor);
    }
}
