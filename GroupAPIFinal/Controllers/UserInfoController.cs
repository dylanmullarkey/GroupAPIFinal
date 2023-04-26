using GroupAPIFinal.Data;
using Microsoft.AspNetCore.Mvc;

namespace GroupAPIFinal.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserInfoController : ControllerBase
    {

        private readonly ILogger<UserInfoController> _logger;
        private readonly UserInfoContext _context;
        public UserInfoController(ILogger<UserInfoController> logger, UserInfoContext context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_context.Hobbies.ToList());
        }
    }
}
