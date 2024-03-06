using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Observer.Interfaces
{
    public interface ISubscribers
    {
        void Notify(string message);
    }
}
