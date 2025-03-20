using Microsoft.EntityFrameworkCore;

namespace BeckonPurses.Data
{
    public class BeckonPursesContext : DbContext
    {
        public BeckonPursesContext(DbContextOptions<BeckonPursesContext> options)
            : base(options)
        {
        }

        public DbSet<BeckonPurses.Models.Purse> Purse { get; set; } = default!;
    }
}
