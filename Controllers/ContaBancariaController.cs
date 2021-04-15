using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static Minhalabcompras.Models.ContaBancariaModel;

namespace Minhalabcompras.Controllers
{
    public class ContaBancariaController : Controller
    {
        public IActionResult Conta()
        {
            return View();
        }

        [HttpGet]
        public IActionResult NovaContaBancaria()
        {
            return View();
        }

        [HttpPost]
        public IActionResult NovaContaBancaria(ContaBancaria NovaContaBancaria )
        {
            if (ModelState.IsValid)
            {
                return View("NovaConta", NovaContaBancaria);
            }
            else
            {
                return View();
            }

        }
    }
}
