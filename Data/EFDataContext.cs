using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using StudyMaster.Data.Entities;

namespace StudyMaster.Data
{
    public class EFDataContext : IdentityDbContext<AppUser, AppRole, int>
    {
        public EFDataContext(DbContextOptions<EFDataContext> opts) : base(opts) { }
        public DbSet<Topic> Topics { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Topic>()
            .HasIndex(b => b.Slug)
            .IsUnique();
        }
    }
}

