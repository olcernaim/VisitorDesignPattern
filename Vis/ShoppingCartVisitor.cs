using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vis
{
    public interface ShoppingCartVisitor
    {
        int visit(Book book);
        int visit(Fruit fruit);
    }
}
