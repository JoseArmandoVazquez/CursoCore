using CursoCap.Models;

namespace CursoCap.Services
{
    public interface IPersonaService
    {
        Task<PersonaViewModel> GetPersonaByIdAsync(int personaId);
        
        Task<List<PersonaViewModel>> GetPersonas();
        Task<PersonaViewModel> PostPersonaAsync(PersonaPostModel modelRequest);
        
        Task<PersonaViewModel> PutPersonaAsync(PersonaPutModel modelRequest, int personaId);
    }
}
