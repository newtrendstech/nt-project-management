using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using ProjectMngmt.DAL.Entity;

namespace ProjectMngmt.DAL
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<Client> ClientRepository { get; }
        IRepository<ProjectCategory> ProjectCategoryRepository { get; }
        IRepository<Project> ProjectRepository { get; }

        int SaveChanges();
    }

    public class UnitOfWork : IUnitOfWork
    {
        private ProjectContext context = new ProjectContext();

        private IRepository<Client> clientRepository;
        private IRepository<ProjectCategory> projectCategoryRepository;
        private IRepository<Project> projectRepository;

        private bool disposed = false;

        public IRepository<Client> ClientRepository
        {
            get
            {
                if (this.clientRepository == null)
                    this.clientRepository = new Repository<Client>(context);

                return clientRepository;
            }
        }

        public IRepository<ProjectCategory> ProjectCategoryRepository
        {
            get
            {
                if (this.projectCategoryRepository == null)
                    this.projectCategoryRepository = new Repository<ProjectCategory>(context);

                return projectCategoryRepository;
            }
        }

        public IRepository<Project> ProjectRepository
        {
            get
            {
                if (this.projectRepository == null)
                    this.projectRepository = new Repository<Project>(context);

                return projectRepository;
            }
        }

        public int SaveChanges()
        {
            return context.SaveChanges();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }


        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
