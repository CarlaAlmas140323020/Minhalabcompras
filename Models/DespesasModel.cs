using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Minhalabcompras.Models
{
  public class Despesa
    {
        [Required(ErrorMessage = "Por favor introduza o seu nome")]
        public string NomeDespesa { get; set; }

        [Required(ErrorMessage = "Por favor introduza a Quantidade")]
        public int Quantidade { get; set; }

        [Required(ErrorMessage = "Por favor introduza o Valor")]
        public double? Valor { get; set; }

        public string Categoria { get; set; }

        public bool Pago { get; set; }
    }

    
}
