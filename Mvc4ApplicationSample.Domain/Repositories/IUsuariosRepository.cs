using Mvc4ApplicationSample.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mvc4ApplicationSample.Domain.Repositories
{
    public interface IUsuariosRepository : IDisposable
    {
        IQueryable<Usuario> Usuarios { get; }
        void Add(Usuario usuario);
        void SaveChanges();
    }
}
