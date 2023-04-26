using GroupAPIFinal.Data;
using GroupAPIFinal.Models;
using GroupAPIFinal.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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

        [HttpPut("{id}")]
        public async Task<IActionResult> PutHobby(int id, UserHobbies hobby)
        {
            if (id != hobby.Id)
            {
                return BadRequest();
            }

            _context.Entry(hobby).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UserHobbies(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }
    }
}
