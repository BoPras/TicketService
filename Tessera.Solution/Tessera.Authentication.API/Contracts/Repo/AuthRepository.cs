using DataAccess;
using Tessera.Authentication.API.Contracts.Interface;

namespace Tessera.Authentication.API.Contracts.Repo
{
    public class AuthRepository : IAuthRepository
    {
        private readonly DapperContext _context;

        public AuthRepository(IConfiguration config)
        {
            _context = new DapperContext(config?.GetConnectionString("TesseraConnection"));
        }
    }
}
