using MySql.Data.MySqlClient.Memcached;
using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Minhalabcompras.Models
{
    public static class Repositorio
    {
        private static List<Produto> Produtos
        {
            get
            {
       LabComprasDbContext context = new LabComprasDbContext();
        List<Produto> produtos = context.Produtos.ToList();
        return produtos;
            }
        }

        public static void AddProduto(Produto NovoProduto)
        {
        LabComprasDbContext context = new LabComprasDbContext();
            context.SaveChanges();
        }

        public static void EliminarProdutos(Produto NovoProduto)
        {
            LabComprasDbContext context = new LabComprasDbContext();
            context.Produtos.c();
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

