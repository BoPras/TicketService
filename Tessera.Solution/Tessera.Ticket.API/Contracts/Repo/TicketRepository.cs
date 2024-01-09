using DataAccess;
using Tessera.Ticket.API.Contracts.Interface;

namespace Tessera.Ticket.API.Contracts.Repo
{
    public class TicketRepository : ITicketRepository
    {
        private readonly DapperContext _context;

        public TicketRepository(IConfiguration config)
        {
            _context = new DapperContext(config?.GetConnectionString("TesseraConnection"));
        }
    }
}
