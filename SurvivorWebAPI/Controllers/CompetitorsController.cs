using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SurvivorWebAPI.Data;
using SurvivorWebAPI.Data.Entity;

namespace SurvivorWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompetitorsController : ControllerBase
    {
        private readonly SurvivorContext _context;

        public CompetitorsController(SurvivorContext context)
        {
            _context = context;
        }

        [HttpGet]

        public ActionResult<List<Competitor>> GetAll()
        {
            var competitors = _context.Competitors.Include (x => x.Category)
                    .Select(c => new { c.Id, c.FirstName, c.LastName, CategoryName = c.Category.Name }).ToList();

            return Ok(competitors);
        }

        [HttpGet("{id}")]

        public ActionResult<Competitor> GetById(int id)
        {
            var competitor = _context.Competitors.FirstOrDefault(c => c.Id == id);
            if (competitor == null) 
                return NotFound();

            return Ok(competitor);
        }

        [HttpGet("competitors/{categoryId}")]

        public ActionResult<List<Competitor>> GetByCategoryId (int categoryId)
        {
            List<Competitor> competitors = _context.Competitors.Where(x => x.CategoryId == categoryId).ToList();

            if(competitors.Count() == 0) 
                return NotFound();

            return Ok(competitors);
        }

        [HttpPost]

        public IActionResult CreateCompetitor ([FromBody] Competitor competitor)
        {
            _context.Competitors.Add(competitor);
            _context.SaveChanges();

            return CreatedAtAction(nameof(GetAll), new { id = competitor.Id }, competitor);
        }

        [HttpPut("{id}")]

        public IActionResult UpdateCompetitor (int id, Competitor competitor)
        {
            var updatedCompetitor = _context.Competitors.FirstOrDefault(x => x.Id == id);

            if (updatedCompetitor == null)
                return BadRequest();

            updatedCompetitor.FirstName = competitor.FirstName;
            updatedCompetitor.LastName = competitor.LastName;
            updatedCompetitor.ModifiedTime = DateTime.Now;

            _context.Competitors.Update(updatedCompetitor);
            _context.SaveChanges();

            return NoContent();
        }

        [HttpDelete("{id}")]

        public IActionResult DeleteCompetitor (int id)
        {
            var deletedCompetitor = _context.Competitors.FirstOrDefault (x => x.Id == id);

            if (deletedCompetitor == null) 
                return NotFound();

            _context.Competitors.Remove(deletedCompetitor);
            _context.SaveChanges();

            return NoContent();
        }
    }
}
