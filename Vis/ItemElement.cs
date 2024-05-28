using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vis
{
    interface ItemElement
    {
        public int accept(ShoppingCartVisitor visitor);
    }
}
