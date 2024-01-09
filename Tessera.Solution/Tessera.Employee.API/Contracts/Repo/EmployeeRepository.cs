using DataAccess;
using Tessera.Employee.API.Contracts.Interface;

namespace Tessera.Employee.API.Contracts.Repo
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly DapperContext _context;

        public EmployeeRepository(IConfiguration config)
        {
            _context = new DapperContext(config?.GetConnectionString("TesseraConnection"));
        }
    }
}
