using BookStoreApi.Services;
using Microsoft.AspNetCore.Mvc;
using PolosoBackend.Models;

namespace PolosoBackend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UiController : ControllerBase
    {
        private readonly DbService _service;

        public UiController(DbService service)
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
    }
}
