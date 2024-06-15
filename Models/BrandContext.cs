using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace CrudOperationslnNetCore.Models
{
    public class BrandContext : DbContext
    {
        public BrandContext(DbContextOptions<BrandContext> options) : base(options) 
        { 
            
        }

        public DbSet <Brand> Brands { get; set; }

    }
}
