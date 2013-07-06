using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.OData;
using System.Data.Entity.Infrastructure;

using ProjectMngmt.Models;

namespace ProjectMngmt.Controllers
{
    public class ClientsController : EntitySetController<Client, int>
    {
        ProjectMngmtContext _context = new ProjectMngmtContext();

        public override IQueryable<Client> Get()
        {
            return _context.Clients;
        }

        protected override Client CreateEntity(Client entity)
        {
            _context.Clients.Add(entity);
            _context.SaveChanges();
            return entity;
        }

        protected override Client UpdateEntity(int key, Client update)
        {
            if (!_context.Clients.Any(c => c.ID == key))
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }

            _context.Clients.Attach(update);
            _context.Entry(update).State = System.Data.EntityState.Modified;
            _context.SaveChanges();

            return update;
        }

        public override void Delete(int key)
        {
            Client client = _context.Clients.FirstOrDefault(c => c.ID == key);
            if (client == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }

            _context.Clients.Remove(client);
            _context.SaveChanges();
        }
    }
}
