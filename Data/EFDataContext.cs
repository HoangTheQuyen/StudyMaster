using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using StudyMaster.Data.Entities;

namespace StudyMaster.Data
{
    public class EFDataContext : IdentityDbContext<AppUser, AppRole, int>
    {
        public EFDataContext(DbContextOptions<EFDataContext> opts) : base(opts) { }
    }
}

