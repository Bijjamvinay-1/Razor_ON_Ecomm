using Microsoft.EntityFrameworkCore;
using Razor_ON_Ecomm.Model;

namespace Razor_ON_Ecomm.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Category> Categories { get; set; }

    }
}
