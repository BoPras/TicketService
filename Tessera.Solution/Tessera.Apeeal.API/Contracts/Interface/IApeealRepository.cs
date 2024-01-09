using Tessera.Apeeal.API.Model;

namespace Tessera.Apeeal.API.Contracts.Interface
{
    public interface IApeealRepository
    {
        List<AppealModel> GetAppeals();
    }
}
