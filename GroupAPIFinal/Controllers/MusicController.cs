using GroupAPIFinal.Data;
using Microsoft.AspNetCore.Mvc;

namespace GroupAPIFinal.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MusicController : ControllerBase
    {

        private readonly ILogger<MusicController> _logger;
        private readonly FullContext _context;
        public MusicController(ILogger<MusicController> logger, FullContext context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_context.Music.ToList());
        }
    }
}
