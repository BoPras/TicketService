using Tessera.Ticket.API.Model;

namespace Tessera.Ticket.API.Contracts.Interface
{
    public interface ITicketRepository
    {
        List<TicketModel> GetAll();
    }
}
