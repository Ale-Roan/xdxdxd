
using Microsoft.EntityFrameworkCore;
using Examen_Unidad_2.Entities;

namespace Examen_Unidad_2
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options ) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Work> Works { get; set; }

        
    }
}