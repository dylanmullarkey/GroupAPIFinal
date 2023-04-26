using GroupAPIFinal.Data;
using GroupAPIFinal.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace GroupAPIFinal.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserLocationInfoController : ControllerBase
    {

        private readonly ILogger<UserLocationInfoController> _logger;
        private readonly IFullContextDAO _context; 
        public UserLocationInfoController(ILogger<UserLocationInfoController> logger, IFullContextDAO context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_context.GetUserLocationInfos());
        }
    }
}