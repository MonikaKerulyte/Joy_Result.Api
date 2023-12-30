using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Result.Api.Model.Dto;
using System.Net;

namespace Result.Api.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class ResultController : ControllerBase
    {
        private readonly ILogger<ResultController> _logger;
        int count = 1;

        public ResultController(ILogger<ResultController> logger)
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        // GET api/v1/[controller]/game[?nrOfJokes=6]
        [HttpGet]
        [ProducesResponseType((int)HttpStatusCode.NoContent)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> SaveResultAsync([FromBody]SaveResultRequest request)
        {
            return NoContent();
        }
    }
}