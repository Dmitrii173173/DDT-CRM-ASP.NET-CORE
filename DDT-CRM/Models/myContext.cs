using Microsoft.EntityFrameworkCore;

namespace DDT_CRM.Models
{
    public class myContext : DbContext
    {
        public myContext(DbContextOptions options) : base(options)
        {
            
        }
        public DbSet<Users> Users { get; set; }
    }
}
