using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mvc4ApplicationSample.Domain.Models
{
    public class Marca
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public virtual ICollection<Carro> Carros { get; set; }
    }
}
