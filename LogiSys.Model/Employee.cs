using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogiSys.Model
{
    public class Employee
    {
        public Employee()
        {
            this.Orders = new HashSet<Order>();
        }

        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int EmployeeNumber { get; set; }

        public Sector Sector { get; set; }

        public ICollection<Order> Orders { get; set; }
    }
}
