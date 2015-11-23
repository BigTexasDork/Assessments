using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace AssessmentRelations.Models
{
    public class AssessmentContext : DbContext
    {
        public DbSet<Client> Clients { get; set; } 
        public DbSet<Project> Projects { get; set; } 
        public DbSet<Assessment> Assessments { get; set; }
        public DbSet<Question> Questions { get; set; } 
        public DbSet<Answer> Answers { get; set; } 
    }
}