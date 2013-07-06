using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data.Entity;

namespace ProjectMngmt.Models
{
    public class ProjectMngmtContext : DbContext
    {
        public ProjectMngmtContext() 
            : base("name = ProjectMngmtContext")
        {
        }

        static ProjectMngmtContext()
        {
            //
        }

        public DbSet<Client> Clients { get; set; }
        public DbSet<ProjectCategory> ProjectCategories { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Task> Tasks { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Developer> Developers { get; set; }
        public DbSet<Issue> Issues { get; set; }
    }
}