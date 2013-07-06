using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data.Entity;

namespace ProjectMngmt.Models
{
    public class ProjectMngmtContextInitializer 
        : DropCreateDatabaseIfModelChanges<ProjectMngmtContext>
    {
        protected override void Seed(ProjectMngmtContext context)
        {            
            base.Seed(context);
        }
    }
}