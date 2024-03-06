using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Template
{
    public class Concorete1 : AbstractClass
    {
        protected override void SpecificOperation()
        {
            Console.WriteLine("Specific Operation for Concrete1");
        }
    }
}
