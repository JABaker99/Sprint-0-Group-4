using Microsoft.EntityFrameworkCore;
using Sprint_0_Group_4.Models;

namespace Sprint_0_Group_4.Data

{
    public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
    {
        public DbSet<AppUser> AppUser { get; set; }
    }
}
