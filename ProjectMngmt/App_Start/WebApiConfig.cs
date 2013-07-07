using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

using System.Web.Http.OData.Builder;

using ProjectMngmt.DAL.Entity;

namespace ProjectMngmt
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.EnableSystemDiagnosticsTracing();

            ODataModelBuilder modelBuilder = new ODataConventionModelBuilder();
            modelBuilder.EntitySet<Client>("Clients");
            modelBuilder.EntitySet<ProjectCategory>("ProjectCategories");
            modelBuilder.EntitySet<Project>("Projects");
            modelBuilder.EntitySet<Team>("Teams");
            modelBuilder.EntitySet<Developer>("Developers");
            modelBuilder.EntitySet<Task>("Tasks");
            modelBuilder.EntitySet<Issue>("Issues");

            Microsoft.Data.Edm.IEdmModel model = modelBuilder.GetEdmModel();
            config.Routes.MapODataRoute("ODataRoute", "odata", model);
        }
    }
}
