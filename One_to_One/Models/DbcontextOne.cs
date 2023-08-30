using Microsoft.EntityFrameworkCore;

namespace One_to_One.Models
{
    public class DbcontextOne : DbContext
    {
        public DbcontextOne(DbContextOptions<DbcontextOne> options):base(options)
        {
            
        }

        public DbSet<Employe> Employes { get; set; }
        public DbSet<AdharDeatails> AdharDeatails { get; set; }
    }
}
