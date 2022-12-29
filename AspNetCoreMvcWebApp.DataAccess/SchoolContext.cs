using AspNetCoreMvcWebApp.Entities;
using Microsoft.EntityFrameworkCore;

namespace AspNetCoreMvcWebApp.DataAccess
{
    /// <summary>
    /// Entity framework context.
    /// </summary>
    public class SchoolContext :DbContext
    {
        public SchoolContext(DbContextOptions<SchoolContext> options) : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }

        /// <summary>
        /// Override the Pluralization that EF mades by default.
        /// </summary>
        /// <param name="builder">Object used to override the EF configuration.</param>
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Student>().ToTable("Student");
            builder.Entity<Course>().ToTable("Course");
            builder.Entity<Enrollment>().ToTable("Enrollment");
        }
    }
}
