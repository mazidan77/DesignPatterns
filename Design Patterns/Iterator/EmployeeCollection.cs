using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Iterator
{
    public class EmployeeCollections : ICollections
    {
        public List<Employee> Employees { get; set; }

        public EmployeeCollections()
        {
            Employees = new List<Employee> { new Employee("1","zidan") ,new Employee ("2","ahmed")};
        }

        public IIterator GetEmplyeeDirectReportIterator()
        {
            return new EmplyeeDirectReportIterator(this);
        } 
        
        public IIterator GetEmployeeCoWorkerIterator()
        {
            return new EmployeeCoWorkerIterator(this);
        }
    }
}
