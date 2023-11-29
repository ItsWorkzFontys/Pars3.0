using Gateway.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Gateway.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GatewayController
    {
        private readonly IGatewayService service;
        private readonly ILogger logger;

        public GatewayController(IGatewayService service, ILogger logger)
        {
            this.service = service;
            this.logger = logger;
        }

        [HttpPost]
        public ActionResult<string> Post()
        {
            string log = logger.LogInformation;
            return log;
        }

        [HttpGet("hello")]
        public ActionResult<string> Get()
        {
            return "Hello world";
        }

        //// POST api/values
        //[HttpPost]
        //public void Post([FromBody] string value)
        //{
        //}
    }
}
