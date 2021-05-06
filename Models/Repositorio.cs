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

        public static void EliminarProdutos(Produto NovoProduto)
        {
            Repositorio.Produtos.Clear();
        }

        private static List<ContaBancaria> conta = new List<ContaBancaria>();

        public static List<ContaBancaria> Contas
        {
            get
            {
                return conta;
            }
        }
        public static void AddContaBancaria(ContaBancaria NovaContaBancaria)
        {
            conta.Add(NovaContaBancaria);

        }

        public static void EliminarContaBancaria(ContaBancaria NovaContaBancaria)
        {
            Repositorio.Contas.Clear();
        }

    }
    }

