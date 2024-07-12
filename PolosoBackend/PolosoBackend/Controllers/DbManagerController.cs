using BookStoreApi.Services;
using Microsoft.AspNetCore.Mvc;
using PolosoBackend.Models;

namespace PolosoBackend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DbManagerController : ControllerBase
    {
        private readonly DbService _service;

        public DbManagerController(DbService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<List<Shirt>> Get()
        {
            return await _service.GetAsync();
        }

        [HttpGet("{id:length(24)}")]
        public async Task<ActionResult<Shirt>> Get(string id)
        {
            var shirt = await _service.GetAsync(id);

            if (shirt is null)
                return NotFound();

            return shirt;
        }

        [HttpPost]
        public async Task<IActionResult> Post(Shirt newShirt)
        {
            await _service.CreateAsync(newShirt);

            return CreatedAtAction(nameof(Get), new { id = newShirt.Id }, newShirt);
        }

        [HttpPut("{id:length(24)}")]
        public async Task<IActionResult> Update(string id, Shirt updatedShirt)
        {
            var shirt = await _service.GetAsync(id);

            if (shirt is null)
                return NotFound();

            updatedShirt.Id = shirt.Id;

            await _service.UpdateAsync(id, updatedShirt);

            return NoContent();
        }

        [HttpDelete("{id:length(24)}")]
        public async Task<IActionResult> Delete(string id)
        {
            var shirt = await _service.GetAsync(id);

            if (shirt is null)
                return NotFound();

            await _service.RemoveAsync(id);

            return NoContent();
        }
    }
}
