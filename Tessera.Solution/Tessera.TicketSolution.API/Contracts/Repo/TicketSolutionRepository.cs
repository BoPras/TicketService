using DataAccess;
using Tessera.TicketSolution.API.Contracts.Interface;
using Tessera.TicketSolution.API.Model;

namespace Tessera.TicketSolution.API.Contracts.Repo
{
    public class TicketSolutionRepository : ITicketSolutionRepository
    {
        private readonly DapperContext _context;

        public TicketSolutionRepository(IConfiguration config)
        {
            _context = new DapperContext(config?.GetConnectionString("TesseraConnection"));
        }

        public List<TicketSolutionModel> GetAll()
        {
            string query = "SELECT * FROM TicketSolutions";
            var result = this._context.GetList<TicketSolutionModel>(query, new Dapper.DynamicParameters { });
            return result;
        }
    }
}
