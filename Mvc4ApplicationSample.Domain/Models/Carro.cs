using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mvc4ApplicationSample.Domain.Models
{
    public class Carro
    {
        public int Id { get; set; }

        public int MarcaId { get; set; }
        public virtual Marca Marca { get; private set; }

        public string Modelo { get; set; }
        
        public virtual ICollection<Pessoa> Pessoas { get; set; }
    }
}
