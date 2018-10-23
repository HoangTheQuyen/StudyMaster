using Microsoft.EntityFrameworkCore;
using StudyMaster.Data.Entities;

namespace StudyMaster.Data
{
    public class EFDataContext : DbContext
    {
        public EFDataContext(DbContextOptions<EFDataContext> opts) : base(opts) { }
        public DbSet<Exam> Exams { get; set; }
        public DbSet<Lecture> Lectures { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Topic> Topics { get; set; }
    }
}

