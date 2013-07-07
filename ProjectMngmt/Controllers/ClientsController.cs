using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.OData;
using System.Data.Entity.Infrastructure;

using ProjectMngmt.DAL;
using ProjectMngmt.DAL.Entity;

namespace ProjectMngmt.Controllers
{
    public class ClientsController : EntitySetController<Client, int>
    {
        readonly IUnitOfWork unitOfWork;        

        public ClientsController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public override IQueryable<Client> Get()
        {
            return unitOfWork.ClientRepository.All();
        }

        protected override Client CreateEntity(Client entity)
        {
            unitOfWork.ClientRepository.Create(entity);
            unitOfWork.SaveChanges();
            return entity;
        }

        protected override Client UpdateEntity(int key, Client update)
        {
            unitOfWork.ClientRepository.Update(update);
            unitOfWork.SaveChanges();

            return update;
        }

        public override void Delete(int key)
        {
            unitOfWork.ClientRepository.Delete(c => c.ID == key);
            unitOfWork.SaveChanges();
        }
    }
}
