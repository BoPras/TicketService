using Tessera.TicketSolution.API.Model;

namespace Tessera.TicketSolution.API.Contracts.Interface
{
    public interface ITicketSolutionRepository
    {
        List<TicketSolutionModel> GetAll();
    }
}
