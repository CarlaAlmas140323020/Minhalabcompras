using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Minhalabcompras.Controllers
{
    public class DespesasController : Controller
    {

        public IActionResult Despesa()
        {
            return View();
        }

        public IActionResult NovaDespesa()
        {
            return View();
        }
    }
}
