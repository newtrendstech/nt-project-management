using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Tracing;
using System.Web.Http.OData;
using System.Data.Entity.Infrastructure;

using ProjectMngmt.DAL;
using ProjectMngmt.DAL.Entity;

namespace ProjectMngmt.Controllers
{
    public class ClientController : EntitySetController<Client, int>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ITraceWriter _tracer;

        public ClientController(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
            _tracer = GlobalConfiguration.Configuration.Services.GetTraceWriter();
        }

        protected override Client GetEntityByKey(int key)
        {
            var client = _unitOfWork.ClientRepository.Filter(c => c.ID == key).FirstOrDefault();
            return client;
        }

        public override IQueryable<Client> Get()
        {
            var clients = _unitOfWork.ClientRepository.All();
            _tracer.Info(Request,
                this.ControllerContext.ControllerDescriptor.ControllerType.FullName,
                "Info Loaded: " + clients.Count());

            return clients;
        }

        protected override Client CreateEntity(Client entity)
        {
            _unitOfWork.ClientRepository.Create(entity);
            _unitOfWork.SaveChanges();
            return entity;
        }

        protected override Client UpdateEntity(int key, Client update)
        {
            _unitOfWork.ClientRepository.Update(update);
            _unitOfWork.SaveChanges();

            return update;
        }

        public override void Delete(int key)
        {
            _unitOfWork.ClientRepository.Delete(c => c.ID == key);
            _unitOfWork.SaveChanges();
        }
    }
}
