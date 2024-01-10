using DataAccess;
using Tessera.Authentication.API.Contracts.Interface;
using Tessera.Authentication.API.Model;

namespace Tessera.Authentication.API.Contracts.Repo
{
    public class AuthRepository : IAuthRepository
    {
        private readonly DapperContext _context;

        public AuthRepository(IConfiguration config)
        {
            _context = new DapperContext(config?.GetConnectionString("TesseraConnection"));
        }

        public void Register()
        {
            var query = "INSERT INTO ";
        }

        public void Login()
        {

        }
    }
}
