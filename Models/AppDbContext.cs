using Microsoft.EntityFrameworkCore;

namespace WebCalulatorMvc.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<CalculationHistory> History { get; set; }
    }
}
