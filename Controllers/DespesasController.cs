﻿using Microsoft.AspNetCore.Mvc;
using Minhalabcompras.Models;
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
       


        [HttpGet]
        public IActionResult NovaDespesa()
        {
            return View();
        }
        [HttpPost]
        public IActionResult NovaDespesa(Despesa NovaDespesa)
        {
            if (ModelState.IsValid) { 

            return View("DespesaConfirmada", NovaDespesa);
            }
            else
            {
                return View();
            }
        }

        
    }
}
