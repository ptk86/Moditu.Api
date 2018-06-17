using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Moditu.Api.Data;
using Moditu.Api.Model;

namespace Moditu.Api.Controllers
{
    [Produces("application/json")]
    [Route("api/Moditus")]
    public class ModitusController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ModitusController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Moditus
        [HttpGet]
        public IEnumerable<Model.Moditu> GetModitus()
        {
            return _context.Moditus;
        }

        // GET: api/Moditus/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetModitu([FromRoute] string id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var moditu = await _context.Moditus.SingleOrDefaultAsync(m => m.Id == id);

            if (moditu == null)
            {
                return NotFound();
            }

            return Ok(moditu);
        }

        // PUT: api/Moditus/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutModitu([FromRoute] string id, [FromBody] Model.Moditu moditu)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != moditu.Id)
            {
                return BadRequest();
            }

            _context.Entry(moditu).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ModituExists(id))
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

        // POST: api/Moditus
        [HttpPost]
        public async Task<IActionResult> PostModitu([FromBody] Model.Moditu moditu)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var key = Guid.NewGuid().ToString().Take(4);
            moditu.Id = string.Concat(key).Insert(0, "#");
            _context.Moditus.Add(moditu);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetModitu", new { id = moditu.Id }, moditu);
        }

        // DELETE: api/Moditus/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteModitu([FromRoute] string id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var moditu = await _context.Moditus.SingleOrDefaultAsync(m => m.Id == id);
            if (moditu == null)
            {
                return NotFound();
            }

            _context.Moditus.Remove(moditu);
            await _context.SaveChangesAsync();

            return Ok(moditu);
        }

        private bool ModituExists(string id)
        {
            return _context.Moditus.Any(e => e.Id == id);
        }
    }
}