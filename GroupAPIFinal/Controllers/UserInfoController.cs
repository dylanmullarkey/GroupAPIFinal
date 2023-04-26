using GroupAPIFinal.Data;
using GroupAPIFinal.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace GroupAPIFinal.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserInfoController : ControllerBase
    {

        private readonly ILogger<UserInfoController> _logger;
        private readonly IFullContextDAO _context;
        public UserInfoController(ILogger<UserInfoController> logger, IFullContextDAO context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_context.GetUserInfos());
        }

        [HttpGet("id")]
        public IActionResult GetById(int id) 
        {
            Var name = _context.Get
        }


        [HttpDelete] 
        public IActionResult Delete(int ) 
        {

        }
    }
}


