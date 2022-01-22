using LogiSys.Model;

namespace LogiSys.Data
{
    public interface IEmployeeLoginService
    {
        Employee Login(int employeeNumber);
    }
}