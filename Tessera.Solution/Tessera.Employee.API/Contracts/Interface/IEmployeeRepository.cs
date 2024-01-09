using Tessera.Employee.API.Model;

namespace Tessera.Employee.API.Contracts.Interface
{
    public interface IEmployeeRepository
    {
        List<EmployeeModel> GetAll();
    }
}
