using GroupAPIFinal.Data;
using Microsoft.AspNetCore.Mvc;

namespace GroupAPIFinal.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserLocationInfoController : ControllerBase
    {

        private readonly ILogger<UserLocationInfoController> _logger;
        private readonly UserLocationContext _context; 
        public UserLocationInfoController(ILogger<UserLocationInfoController> logger, UserLocationContext context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_context.Location.ToList());
        }
    }
}