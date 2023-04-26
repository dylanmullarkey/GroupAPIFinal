using GroupAPIFinal.Data;
using GroupAPIFinal.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace GroupAPIFinal.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MusicController : ControllerBase
    {

        private readonly ILogger<MusicController> _logger;
        private readonly IFullContextDAO _context;
        public MusicController(ILogger<MusicController> logger, IFullContextDAO context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_context.GetUserMusics());
        }
    }
}
