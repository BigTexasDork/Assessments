using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AssessmentRelations.Models
{
    public class Client
    {
        public Client()
        {
            if (Projects == null)
            {
                Projects = new List<Project>();
            }
        }

        public int Id { get; set; }
        public string Name { get; set; }
        ICollection<Project> Projects { get; set; }

        public void AddProject(Project p)
        {
            Projects.Add(p);
        }
    }
}