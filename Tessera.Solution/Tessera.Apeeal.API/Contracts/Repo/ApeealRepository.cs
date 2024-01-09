using DataAccess;
using Tessera.Apeeal.API.Contracts.Interface;

namespace Tessera.Apeeal.API.Contracts.Repo
{
    public class ApeealRepository : IApeealRepository
    {
        private readonly DapperContext _context;

        public ApeealRepository(IConfiguration config)
        {
            _context = new DapperContext(config?.GetConnectionString("TesseraConnection"));
        }
    }
}
