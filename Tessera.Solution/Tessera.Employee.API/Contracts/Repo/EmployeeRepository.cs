using DataAccess;
using Tessera.Employee.API.Contracts.Interface;
using Tessera.Employee.API.Model;

namespace Tessera.Employee.API.Contracts.Repo
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly DapperContext _context;

        public EmployeeRepository(IConfiguration config)
        {
            _context = new DapperContext(config?.GetConnectionString("TesseraConnection"));
        }

        public List<EmployeeModel> GetAll()
        {
            string query = "SELECT * FROM Employees";
            var result = this._context.GetList<EmployeeModel>(query, new Dapper.DynamicParameters { });
            return result;
        }
    }
}
