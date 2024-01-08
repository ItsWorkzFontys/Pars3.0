using Gateway.Dtos;
using Gateway.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Gateway.Controllers
{
    [ApiController]
    [Route("/api/[controller]/")]
    public class GatewayController : Controller
    {
        private readonly IGatewayService service;
        //private readonly ILogger logger;

        //public GatewayController(IGatewayService service, ILogger<GatewayDto> logger)
        public GatewayController(IGatewayService service)
        {
            this.service = service;
            //this.logger = logger;
        }

        [HttpPost]
        public ActionResult<string> Post()
        {
            string log = "log";
            return log;
        }

        [HttpGet("hello")]
        public ActionResult<string> Get()
        {
            //logger.LogInformation("Gateway visited at {DT}",
            //DateTime.UtcNow.ToLongTimeString());
            //Console.WriteLine(logger.ToString());
            return "Hello world";
        }

        [HttpPost("task")]
        [ProducesResponseType(typeof(string), StatusCodes.Status200OK)]
        public async Task<IActionResult> Post2()
        {
            return Ok("hello there");
        }
    }
}
