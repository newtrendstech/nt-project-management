using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.Entity;

using ProjectMngmt.DAL.Entity;

namespace ProjectMngmt.DAL
{
    public class ProjectContextInitializer
        : DropCreateDatabaseIfModelChanges<ProjectContext>
    {
        protected override void Seed(ProjectContext context)
        {
            var clients = new List<Client>() { 
                new Client() { Name = "Client1", Email = "client1@gmail.com"},
                new Client() { Name = "Client2", Email = "client2@gmail.com"}
            };
            clients.ForEach(c => context.Clients.Add(c));

            base.Seed(context);
        }
    }
}
