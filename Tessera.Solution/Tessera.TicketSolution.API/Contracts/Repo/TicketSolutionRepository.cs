using DataAccess;
using Tessera.TicketSolution.API.Contracts.Interface;

namespace Tessera.TicketSolution.API.Contracts.Repo
{
    public class TicketSolutionRepository : ITicketSolutionRepository
    {
        private readonly DapperContext _context;

        public TicketSolutionRepository(IConfiguration config)
        {
            _context = new DapperContext(config?.GetConnectionString("TesseraConnection"));
        }
    }
}
