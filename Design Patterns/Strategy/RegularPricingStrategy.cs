﻿using Design_Patterns.Strategy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Strategy
{
    public class RegularPricingStrategy : IPricingStrategy
    {
        public double CalculatePrice(int price)
        {
            return price;
        }
    }
}
