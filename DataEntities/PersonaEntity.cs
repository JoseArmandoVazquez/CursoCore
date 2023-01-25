using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CursoCap.DataEntities
{
    public class PersonaEntity
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(60)]
        public string Nombre { get; set; }
        [MaxLength(80)]
        public string Apellidos { get; set; }


    }
}
