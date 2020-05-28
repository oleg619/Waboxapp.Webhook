using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Waboxapp.Webhook.Controllers
{
    [Route("api/[controller]")]
    public class WaboxappController : Controller
    {
        private readonly ILogger<WaboxappController> _logger;

        public WaboxappController(
            ILogger<WaboxappController> logger)
        {
            _logger = logger;
        }

        [HttpPost("update")]
        [Consumes("application/x-www-form-urlencoded")]
        public Task Update([FromForm] Update update)
        {
            _logger.LogInformation("We received new {@message}", update);
            
            return Task.CompletedTask;
        }
    }

    public class Message
    {
        public long Dtm { get; set; }
        public string UId { get; set; }
        public string CuId { get; set; }
        public string Dir { get; set; }
        public string Type { get; set; }
        public Body Body { get; set; }
        public string Ack { get; set; }
    }

    public class Contact
    {
        public long Uid { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
    }

    public class Update
    {
        public string Event { get; set; }
        public string Token { get; set; }
        public long Uid { get; set; }
        
        public Contact Contact { get; set; }
        public Message Message { get; set; }
    }

    public class Body
    {
        public string Text { get; set; }
    }
}