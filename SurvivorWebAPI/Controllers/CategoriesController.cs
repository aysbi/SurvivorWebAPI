using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SurvivorWebAPI.Data;
using SurvivorWebAPI.Data.Entity;

namespace SurvivorWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly SurvivorContext _context;

        public CategoriesController(SurvivorContext context)
        {
            _context = context;
        }

        [HttpGet("categories")]

        public async Task<ActionResult<List<Category>>> GetAll()
        {
            var categories = await _context.Categories.Include(c => c.Competitors).Select(x => new
            {
                x.Id,
                x.Name,
                Competitors = x.Competitors.Select(c => new { c.Id, c.FirstName, c.LastName })
            }).ToListAsync();
            return Ok(categories);
        } 

        [HttpGet("categories/{id}")]

        public async Task<ActionResult<Category>> GetById (int id)
        {
            var category = await _context.Categories.SingleOrDefaultAsync(c => c.Id == id);
            
            if (category == null)
                return NotFound();

            return Ok(category);
        }

        [HttpPost("categories")]

        public async Task<ActionResult<Category>> Create ([FromBody]Category newCategory)
        {
            _context.Categories.Add(newCategory);
            await _context.SaveChangesAsync();

            var category = new Category
            {
                Id = newCategory.Id,
                Name = newCategory.Name
            }; 
            
            _context.Categories.Add(category);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(Create), new { id = category.Id }, category);
        }

        [HttpPut("categories/{id}")]

        public IActionResult Update(int id, [FromBody]Category newCategory)
        {
            var updatedVersion = _context.Categories.FirstOrDefault(x => x.Id == id);
            if (updatedVersion == null)
                return BadRequest();

            updatedVersion.Name = newCategory.Name;
            updatedVersion.ModifiedTime = DateTime.UtcNow;

            _context.Categories.Update(updatedVersion);
            _context.SaveChanges();

            return NoContent();
        }

        [HttpDelete("categories/{id}")]

        public IActionResult Delete (int id)
        {
            var category = _context.Categories.SingleOrDefault(x => x.Id == id);
           
            if (category == null) 
                return NotFound();
            
            _context.Categories.Remove(category);
            _context.SaveChanges();

            return NoContent();
        }





    }
}
