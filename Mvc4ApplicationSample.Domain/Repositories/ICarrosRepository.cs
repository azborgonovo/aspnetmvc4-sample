using Mvc4ApplicationSample.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mvc4ApplicationSample.Domain.Repositories
{
    public interface ICarrosRepository : IDisposable
    {
        IQueryable<Carro> Carros { get; }
        Carro Find(int id);
        void Add(Carro carro);
        void Remove(Carro carro);
        void Update(Carro carro);
        void SaveChanges();
    }
}
