using DataAccess;
using Tessera.Ticket.API.Contracts.Interface;
using Tessera.Ticket.API.Model;

namespace Tessera.Ticket.API.Contracts.Repo
{
    public class TicketRepository : ITicketRepository
    {
        private readonly DapperContext _context;

        public TicketRepository(IConfiguration config)
        {
            _context = new DapperContext(config?.GetConnectionString("TesseraConnection"));
        }

        public List<TicketModel> GetAll()
        {
            string query = "SELECT * FROM Tickets";
            var result = this._context.GetList<TicketModel>(query, new Dapper.DynamicParameters { });
            return result;
        }
    }
}
