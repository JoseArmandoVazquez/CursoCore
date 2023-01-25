using CursoCap.Models;
using CursoCap.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System.Runtime.CompilerServices;


namespace CursoCap.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonaController : ControllerBase
    {
        private readonly IPersonaService _personaService;

        public PersonaController(IPersonaService personaService)
        {
            _personaService = personaService;
        }

        [HttpGet]

        public async Task<IActionResult> Get()
        {
            return StatusCode(200, await _personaService.GetPersonas());
        }

        [HttpGet("{personaId}")]
        public async Task<IActionResult> GetPersonaByIdAsync(int personaId)
        {
            return StatusCode(200, await _personaService.GetPersonaByIdAsync(personaId));
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] PersonaPostModel model)
        {
            return StatusCode(201, await _personaService.PostPersonaAsync(model));
        }

        [HttpPut("{personaId}")]
        public async Task<IActionResult> Put([FromBody] PersonaPutModel model, int personaId)
        {
            return StatusCode(200, await _personaService.PutPersonaAsync(model, personaId));    
        }
    }
    
}
