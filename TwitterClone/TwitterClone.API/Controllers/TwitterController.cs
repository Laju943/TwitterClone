using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TwitterClone.API.Attributes;

namespace TwitterClone.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TwitterController : ControllerBase
    {
        private readonly IConfiguration _configuration;

        public TwitterController(IConfiguration configuration)
        {
            _configuration= configuration;
        }

        //[Tweet]
        [HttpGet]
        public void GetTweet()
        {
            var connectionString = _configuration.GetValue<string>("Logging:LogLevel:Default");
        }
    }
}
