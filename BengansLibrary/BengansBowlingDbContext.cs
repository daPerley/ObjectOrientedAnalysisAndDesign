using Microsoft.EntityFrameworkCore;

namespace BengansBowlinghallLibrary
{
    public class BengansBowlingDbContext : DbContext
    {
        public DbSet<Party> Parties { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           optionsBuilder.UseSqlServer(@"Server = (localdb)\mssqllocaldb; Database = EFGetStarted.ConsoleApp.NewDb; Trusted_Connection = True; ");
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Party>().HasKey(p => p.Id);
        }
    }
}
