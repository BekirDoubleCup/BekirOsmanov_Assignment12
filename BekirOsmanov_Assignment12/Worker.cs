using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BekirOsmanov_Assignment12
{
    public class Worker : Employee
    {

        public Worker(string name, int id, int shift, decimal payHour) : base(name, id)
        {
            shiftNumber = shift;
            dollarHour = payHour;
        }
        public int shiftNumber { get; set; }
        public decimal dollarHour { get; set; }

        public override string ToString()
        {
            return base.ToString() + "Worker Shift: " + shiftNumber + "\r\n" + "Worker Hourly Pay: " + dollarHour + "\r\n";  
        }
    }
}
