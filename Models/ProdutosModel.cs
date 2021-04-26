using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Minhalabcompras.Models
{
    public class Produto
    {
        [Required(ErrorMessage ="Por favor introduza o Id do produto")]
        public int? ID { get; set; }

        [Required(ErrorMessage ="Por favor introduza o nome do produto")]
        public string Nome { get; set; }

        public string Categoria { get; set; }

        public double? Preco { get; set; }

        public bool EmStock { get; set; }
    }
}
