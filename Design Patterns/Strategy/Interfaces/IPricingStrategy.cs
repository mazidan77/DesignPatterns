using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Strategy.Interfaces
{
    public interface IPricingStrategy
    {
        double CalculatePrice(int price);
    }
}
