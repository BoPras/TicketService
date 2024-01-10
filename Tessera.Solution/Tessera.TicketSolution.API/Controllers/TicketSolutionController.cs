using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Tessera.TicketSolution.API.Contracts.Interface;

namespace Tessera.TicketSolution.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TicketSolutionController : ControllerBase
    {
        private readonly ITicketSolutionRepository _ticketSolutionRepository;

        public TicketSolutionController(ITicketSolutionRepository ticketSolutionRepository)
        {
            _ticketSolutionRepository = ticketSolutionRepository;
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(this._ticketSolutionRepository.GetAll());
            }
            catch (Exception e)
            {

                return StatusCode(500, e.Message);
            }
        }
    }
}
