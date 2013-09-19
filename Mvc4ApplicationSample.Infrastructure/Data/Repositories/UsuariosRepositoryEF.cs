using Mvc4ApplicationSample.Domain.Models;
using Mvc4ApplicationSample.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mvc4ApplicationSample.Infrastructure.Data.Repositories
{
    public class UsuariosRepositoryEF : IUsuariosRepository
    {
        Mvc4ApplicationSampleDbContext _dbContext;

        public UsuariosRepositoryEF(Mvc4ApplicationSampleDbContext dbContext)
        {
            if (dbContext == null) throw new ArgumentNullException("dbContext");

            _dbContext = dbContext;
        }

        public IQueryable<Usuario> Usuarios
        {
            get { return _dbContext.Usuarios; }
        }

        public void Add(Usuario usuario)
        {
            _dbContext.Usuarios.Add(usuario);
        }
        
        public void SaveChanges()
        {
            _dbContext.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _dbContext.Dispose();
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
