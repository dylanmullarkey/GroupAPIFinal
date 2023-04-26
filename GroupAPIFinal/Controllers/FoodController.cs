using GroupAPIFinal.Data;
using Microsoft.AspNetCore.Mvc;

namespace GroupAPIFinal.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FoodController : ControllerBase
    {

        private readonly ILogger<FoodController> _logger;
        private readonly FullContext _context;
        public FoodController(ILogger<FoodController> logger, FullContext context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_context.Foods.ToList());
        }
    }
}
