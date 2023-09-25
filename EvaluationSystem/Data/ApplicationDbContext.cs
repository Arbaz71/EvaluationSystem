using EvaluationSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace EvaluationSystem.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        { 
        }
        
        public DbSet<Choice>Choices { get; set; }
        public DbSet<Course> Courses { get; set; }  
       
        public DbSet<EnrollmentRequest> EnrollmentRequests { get; set; }
        public DbSet<Question>Questions { get; set; }
        public DbSet<Result> Results { get; set; }
        public DbSet<Semester> Semesters { get; set; }
        
        public DbSet<Survey>Surveys { get; set; }
        public DbSet<User> Users { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Course>()
                .HasOne(c => c.Instructor)           // Course has one Instructor
                .WithOne(i => i.Course)              // Instructor has one Course
                .HasForeignKey<Instructor>(i => i.CourseCode);  // Foreign key in Instructor
        }

    }
}
