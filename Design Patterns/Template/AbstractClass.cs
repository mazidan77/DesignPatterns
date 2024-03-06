using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Template
{
    public abstract class AbstractClass
    {
        public void TemplateMethod()
        {
            CommonOperation1();
            SpecificOperation();
            CommonOperation2();
        }

        protected abstract void SpecificOperation();


        protected  void CommonOperation1()
        {
            Console.WriteLine("Common Operation 1");
        } 
        protected  void CommonOperation2()
        {
            Console.WriteLine("Common Operation 2");
        }
    }
}
