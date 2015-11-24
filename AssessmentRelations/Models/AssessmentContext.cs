using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace AssessmentRelations.Models
{
    public class AssessmentContext : DbContext
    {
        public DbSet<Client> Clients { get; set; } 
        public DbSet<Project> Projects { get; set; } 
        public DbSet<Assessment> Assessments { get; set; }
        public DbSet<Question> Questions { get; set; } 
        public DbSet<Answer> Answers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

    }
}