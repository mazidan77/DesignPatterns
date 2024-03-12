using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Iterator
{
    public class Employee
    {
        public string Id { get; set; }
        public string Name { get; set; }

        public Employee(string Id , string Name)
        {
            this.Id = Id;
            this.Name = Name;
                
        }

    }
}
