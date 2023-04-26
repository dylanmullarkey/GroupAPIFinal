using GroupAPIFinal.Data;
using GroupAPIFinal.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace GroupAPIFinal.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FoodController : ControllerBase
    {

        private readonly ILogger<FoodController> _logger;
        private readonly IFullContextDAO _context;
        public FoodController(ILogger<FoodController> logger, IFullContextDAO context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_context.GetUserFoods());
        }
    }
}
