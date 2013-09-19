using Mvc4ApplicationSample.Domain.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mvc4ApplicationSample.Domain.Models
{
    public class Pessoa
    {
        public int Id { get; set; }
        
        [Required(ErrorMessageResourceType=typeof(Mensagens), ErrorMessageResourceName="Pessoa_NomeEhObrigatorio")]
        public string Nome { get; set; }

        public ICollection<Carro> Carros { get; set; }
    }
}
