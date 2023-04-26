using GroupAPIFinal.Data;
using GroupAPIFinal.Models;
using GroupAPIFinal.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GroupAPIFinal.Controllers
/*{
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
}*/

{
    [ApiController]
public class HobbiesController : ControllerBase
{
    private readonly ApplicationDbContext _context;

    public HobbiesController(ApplicationDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Hobby>>> GetHobbies(int? id)
    {
        if (id == null || id == 0)
        {
            return await _context.Hobbies.Take(5).ToListAsync();
        }
        else
        {
            return await _context.Hobbies.FindAsync(id);
        }
    }

    [HttpPost]
    public async Task<ActionResult<Hobby>> PostHobby(Hobby hobby)
{
_context.Hobbies.Add(hobby);
await _context.SaveChangesAsync();
    return CreatedAtAction(nameof(GetHobbies), new { id = hobby.Id }, hobby);
}

[HttpPut("{id}")]
public async Task<IActionResult> PutHobby(int id, Hobby hobby)
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
        if (!HobbyExists(id))
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

[HttpDelete("{id}")]
public async Task<IActionResult> DeleteHobby(int id)
{
    var hobby = await _context.Hobbies.FindAsync(id);
    if (hobby == null)
    {
        return NotFound();
    }

    _context.Hobbies.Remove(hobby);
    await _context.SaveChangesAsync();

    return NoContent();
}

private bool HobbyExists(int id)
{
    return _context.Hobbies.Any(e => e.Id == id);
}
}

}
