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
    public class CarrosRepositoryEF : ICarrosRepository
    {
        Mvc4ApplicationSampleDbContext _dbContext;

        public CarrosRepositoryEF(Mvc4ApplicationSampleDbContext dbContext)
        {
            if (dbContext == null) throw new ArgumentNullException("dbContext");

            _dbContext = dbContext;
        }

        public IQueryable<Carro> Carros
        {
            get { return _dbContext.Carros; }
        }

        public Carro Find(int id)
        {
            return _dbContext.Carros.Find(id);
        }

        public void Add(Carro carro)
        {
            _dbContext.Carros.Add(carro);
        }

        public void Remove(Carro carro)
        {
            _dbContext.Carros.Remove(carro);
        }

        public void Update(Carro carro)
        {
            _dbContext.Entry(carro).State = EntityState.Modified;
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
