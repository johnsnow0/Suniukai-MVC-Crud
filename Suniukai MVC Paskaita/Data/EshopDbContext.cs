using Microsoft.EntityFrameworkCore;
using Suniukai_MVC_Paskaita.Models;

namespace Suniukai_MVC_Paskaita.Data
{
    public class EshopDbContext : DbContext
    {
        public EshopDbContext(DbContextOptions<EshopDbContext> options) : base(options) { }

        public DbSet<Preke> Prekes { get; set; }

        
    }
}
