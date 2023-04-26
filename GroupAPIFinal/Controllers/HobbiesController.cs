using GroupAPIFinal.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GroupAPIFinal.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HobbiesController : ControllerBase
    {

        private readonly ILogger<HobbiesController> _logger;
        private readonly FullContext _context;
        public HobbiesController(ILogger<HobbiesController> logger, FullContext context)
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