using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Iterator
{
    public interface IIterator
    {
        bool HasNext();
        Employee GetNext();

    }
}
