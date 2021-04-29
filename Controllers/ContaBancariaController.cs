using Microsoft.AspNetCore.Mvc;
using Minhalabcompras.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Minhalabcompras.Controllers
{
    public class ContaBancariaController : Controller
    {
        public IActionResult Index()
        {
            List<ContaBancaria> MinhasContas = Repositorio.Contas;
            return View(MinhasContas);

        }
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
        public IActionResult NovaContaBancaria(ContaBancaria MinhaNovaContaBancaria)
        {
            if (ModelState.IsValid)
            {
                 Repositorio.AddContaBancaria(MinhaNovaContaBancaria);
                return View("NovaConta", MinhaNovaContaBancaria);
            }
            else
            {
                return View();
            }

        }

        public IActionResult RemoverContaBancaria(ContaBancaria MinhaNovaContaBancaria)
        {
            Repositorio.Contas.Clear();
            return View("SemContasBancarias", MinhaNovaContaBancaria);
        }
   
    }
}