namespace CursoCap.Models
{
    
        public class PersonaViewModel
        {
            public int Id { get; set; }
            public string Nombre { get; set; }
            public string Apellidos { get; set; }
            
        }
    public class PersonaPostModel
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }

    }

    public class PersonaPutModel
    {
        public string Nombre { get; set; }
        public string Apellidos { get; set; }

    }
  
    

}
