using CursoCap.DataEntities;
using Microsoft.EntityFrameworkCore;

namespace CursoCap.DataContext
{
    public class CursoAspNetCoreDbContext : DbContext
    {
        public CursoAspNetCoreDbContext(DbContextOptions<CursoAspNetCoreDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }


        //declaracion de entidades
           public DbSet<PersonaEntity> Persona { get; set; }
        
    }


    
  
}

