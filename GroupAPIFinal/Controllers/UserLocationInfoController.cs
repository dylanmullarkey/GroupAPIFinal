using GroupAPIFinal.Data;
using Microsoft.AspNetCore.Mvc;

namespace GroupAPIFinal.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserLocationInfoController : ControllerBase
    {

        private readonly ILogger<UserLocationInfoController> _logger;
        private readonly FullContext _context; 
        public UserLocationInfoController(ILogger<UserLocationInfoController> logger, FullContext context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_context.UserLocation.ToList());
        }
    }
}