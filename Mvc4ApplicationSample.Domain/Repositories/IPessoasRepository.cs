using Mvc4ApplicationSample.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mvc4ApplicationSample.Domain.Repositories
{
    public interface IPessoasRepository : IDisposable
    {
        IQueryable<Pessoa> Pessoas { get; }
        Pessoa Find(int id);
        void Add(Pessoa pessoa);
        void Remove(Pessoa pessoa);
        void Update(Pessoa pessoa);
        void SaveChanges();
    }
}
