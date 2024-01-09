using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Tessera.Apeeal.API.Contracts.Interface;

namespace Tessera.Apeeal.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppealController : ControllerBase
    {
        private readonly IApeealRepository _appealRepository;

        public AppealController(IApeealRepository appealRepository)
        {
            _appealRepository = appealRepository;
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(this._appealRepository.GetAppeals());
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }
    }
}
