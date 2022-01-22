using LogiSys.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogiSys.Data
{
    public class EmployeeLoginService : IEmployeeLoginService
    {
        public Employee Login(int employeeNumber)
        {
            return new Employee();
        }
    }
}
