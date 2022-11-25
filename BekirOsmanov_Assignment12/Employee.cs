using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BekirOsmanov_Assignment12
{
    public class Employee
    {
        public Employee(string name, int id)
        {
            employeeName = name;
            employeeNumber = id;
        }
        public string employeeName { get; set; }
        public int employeeNumber { get; set; }

        public override string ToString()
        {
            return "Employee Name: " + employeeName + "\r\n" + "Employee Id: " + employeeNumber + "\r\n"  ;
        }
    }
}
