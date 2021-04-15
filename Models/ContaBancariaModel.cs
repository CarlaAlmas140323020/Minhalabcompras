using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Minhalabcompras.Models
{
    public class ContaBancariaModel : Controller
    {

        public class ContaBancaria
        {
            [Required(ErrorMessage = "Por favor introduza o seu nome")]
            public string NomeDoTitular { get; set; }

            [Required(ErrorMessage = "Por favor introduza o saldo")]
            public int Saldo { get; set; }

            public bool Ativa { get; set; }
        }
    }
}
