using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Minhalabcompras.Models
{
    public static class Repositorio
    {
        private static List<Produto> produtos = new List<Produto>();

        public static List<Produto> Produtos
        {
            get
            {
                return produtos;
            }
        }
        public static void AddProduto(Produto NovoProduto)
        {
            produtos.Add(NovoProduto);
        }
    }
}
