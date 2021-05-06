using Microsoft.AspNetCore.Mvc;
using Minhalabcompras.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Minhalabcompras.Controllers
{
    public class ProdutosController : Controller
    {
        public IActionResult Index()
        {
           List<Produto> MeusProdutos=Repositorio.Produtos;
            return View(MeusProdutos);
        }

        [HttpGet]
        public IActionResult NovoProduto()
        {
            return View();
        }

        [HttpPost]

        public IActionResult NovoProduto(Produto MeuNovoProduto)
        {
            if (ModelState.IsValid)
            {
                Repositorio.AddProduto(MeuNovoProduto);
                return View("ProdutoConfirmado", MeuNovoProduto);
            }
            else
            {
                return View();
            }
        }

        public IActionResult EliminarProdutos(Produto MeuNovoProduto)
        {
            Repositorio.EliminarProdutos(MeuNovoProduto);
            return View("ProdutosEliminados", MeuNovoProduto);
        }
    }
}
