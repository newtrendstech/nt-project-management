using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;

using ProjectMngmt.DAL.Entity;

namespace ProjectMngmt.DAL
{
    public class ProjectContext : DbContext
    {
        public ProjectContext()
            : base("name = ProjectContext")
        {
        }

        static ProjectContext()
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
