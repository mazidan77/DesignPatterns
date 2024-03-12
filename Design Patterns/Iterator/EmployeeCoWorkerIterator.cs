using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Iterator
{
    public class EmployeeCoWorkerIterator : IIterator
    {
        public EmployeeCollections EmployeeCollection { get; set; }
        public int Position { get; set; }

        public EmployeeCoWorkerIterator(EmployeeCollections EmployeeCollection)
        {
            this.EmployeeCollection = EmployeeCollection;
        }

        public bool HasNext()
        {
            return Position < EmployeeCollection.Employees.Count;
        }

        public Employee GetNext()
        {
            Console.WriteLine("from direct report");
            if (!HasNext())
            {
                return null;
            }
            return EmployeeCollection.Employees[Position++];
        }
    }
}
