using GroupAPIFinal.Data;
using GroupAPIFinal.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace GroupAPIFinal.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HobbiesController : ControllerBase
    {

        private readonly ILogger<HobbiesController> _logger;
        private readonly IFullContextDAO _context;
        public HobbiesController(ILogger<HobbiesController> logger, IFullContextDAO context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_context.GetHobbiess());
        }
    }
}
