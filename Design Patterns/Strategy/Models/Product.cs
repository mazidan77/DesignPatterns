using Design_Patterns.Strategy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Strategy.Models
{
    public class Product
    {
        public string Name { get; set; }
        public int Price { get; set; }

        public IPricingStrategy pricingStrategy { get; set; }

        public Product(string Name , int Price , IPricingStrategy pricingStrategy)
        {
            this.Name = Name;
            this.Price = Price;
            this.pricingStrategy = pricingStrategy;
                
        }

        public double CalculatePrice()
        {
            return pricingStrategy.CalculatePrice(Price);
        }
    }
}
