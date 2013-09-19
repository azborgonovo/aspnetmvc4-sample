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
    public class PessoasRepositoryEF : IPessoasRepository
    {
        Mvc4ApplicationSampleDbContext _dbContext;

        public PessoasRepositoryEF(Mvc4ApplicationSampleDbContext dbContext)
        {
            if (dbContext == null) throw new ArgumentNullException("dbContext");

            _dbContext = dbContext;
        }

        public IQueryable<Pessoa> Pessoas
        {
            get { return _dbContext.Pessoas; }
        }

        public Pessoa Find(int id)
        {
            return _dbContext.Pessoas.Find(id);
        }

        public void Add(Pessoa pessoa)
        {
            _dbContext.Pessoas.Add(pessoa);
        }

        public void Remove(Pessoa pessoa)
        {
            _dbContext.Pessoas.Remove(pessoa);
        }

        public void Update(Pessoa pessoa)
        {
            _dbContext.Entry(pessoa).State = EntityState.Modified;
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
