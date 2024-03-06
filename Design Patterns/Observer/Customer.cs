using Design_Patterns.Observer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Observer
{
    public class Customer:ISubscribers
    {
        public string Name { get; set; }

        public Customer(string Name)
        {
            this.Name = Name;    
        }
        public void Notify(string message)
        {
            Console.WriteLine($"hi customer {Name}, {message} ");
        }
    }
}
