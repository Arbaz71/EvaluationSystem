using EvaluationSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace EvaluationSystem.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        { 
        }
        public DbSet<Admin>Admins { get; set; }
        public DbSet<Choice>Choices { get; set; }
        public DbSet<Course> Courses { get; set; }  
        public DbSet<DepartmentManager> DepartmentManagers { get; set; }
        public DbSet<EnrollmentRequest> EnrollmentRequests { get; set; }
        public DbSet<Instructor>Instructors { get; set; }
        public DbSet<Question>Questions { get; set; }
        public DbSet<Result> Results { get; set; }
        public DbSet<Semester> Semesters { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Survey>Surveys { get; set; }
        public DbSet<User> Users { get; set; }

    }
}
