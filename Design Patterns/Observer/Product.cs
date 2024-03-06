using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Observer
{
    public class Product
    {
        public string Name { get; set; }
        public int Price { get; set; }

        public Product(string Name , int Price)
        {
            this.Name = Name;
            this.Price = Price;
        }
    }
}
