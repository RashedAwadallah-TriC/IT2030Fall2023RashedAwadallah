using Microsoft.EntityFrameworkCore;
using RashedApparel.Models;

namespace RashedApparel.Data
{
    public class RashedApparelContext : DbContext
    {
        public RashedApparelContext(DbContextOptions<RashedApparelContext> options) : base(options) 
        { 
        
        }

        public DbSet<ProductModel> ProductDb { get; set; }

        public DbSet<ContactModel> ContactDb { get; set; }
    }
}
