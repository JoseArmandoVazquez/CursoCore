using CursoCap.DataContext;
using CursoCap.DataEntities;
using CursoCap.Models;
using Microsoft.EntityFrameworkCore;

namespace CursoCap.Services.Implementations
{
    public class PersonaService: IPersonaService
    {

        private readonly CursoAspNetCoreDbContext _dbContext;
        public PersonaService(CursoAspNetCoreDbContext dbContext) 
        {
            _dbContext = dbContext;
        }


        public async Task<PersonaViewModel> PostPersonaAsync(PersonaPostModel modelRequest)
        {
            PersonaEntity newPersona = new PersonaEntity
            {
                Nombre= modelRequest.Nombre,
                Apellidos= modelRequest.Apellidos
            };

            await _dbContext.Persona.AddAsync(newPersona);
            await _dbContext.SaveChangesAsync();

            return new PersonaViewModel
            { 
                Id = newPersona.Id,
                Nombre = newPersona.Nombre,
                Apellidos = newPersona.Apellidos,
            };
        }

/// ///////


        public async Task<List<PersonaViewModel>> GetPersonas()
        {
            var listaPersonas = await _dbContext
                .Persona
                .Select(s => new PersonaViewModel
                {
                    Id = s.Id,
                    Nombre = s.Nombre,
                    Apellidos = s.Apellidos,
                })
                .ToListAsync();

            return listaPersonas;
        }
        
        public async Task<PersonaViewModel> GetPersonaByIdAsync(int personaId)
        {
            var persona = await _dbContext.Persona.FindAsync(personaId);

            if(persona == null)
            {
                return null;
            }

            return new PersonaViewModel
            {
                Id = persona.Id,
                Nombre = persona.Nombre,
                Apellidos = persona.Apellidos,
            };

        }

        public async Task<PersonaViewModel> PutPersonaAsync(PersonaPutModel modelRequest, int personaId)
        {
            var persona = await _dbContext.Persona.FindAsync(personaId);
            if (persona == null)
            {
                return null;
            }
            persona.Nombre= modelRequest.Nombre;
            persona.Apellidos= modelRequest.Apellidos;
            await _dbContext.SaveChangesAsync();

            return new PersonaViewModel
            {
                Id = persona.Id,
                Nombre = persona.Nombre,
                Apellidos = persona.Apellidos,
            };
        }
    }
}
