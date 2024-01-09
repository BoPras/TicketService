using DataAccess;
using Tessera.Apeeal.API.Contracts.Interface;
using Tessera.Apeeal.API.Model;

namespace Tessera.Apeeal.API.Contracts.Repo
{
    public class ApeealRepository : IApeealRepository
    {
        private readonly DapperContext _context;

        public ApeealRepository(IConfiguration config)
        {
            _context = new DapperContext(config?.GetConnectionString("TesseraConnection"));
        }

        public List<AppealModel> GetAppeals()
        {
            string query = "SELECT * FROM Appeals";
            List<AppealModel> result = this._context.GetList<AppealModel>(query, new Dapper.DynamicParameters { });
            return result;
        }
    }
}
