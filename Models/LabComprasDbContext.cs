
using System;
using System.Collections.Generic;
using System.Linq;
using Minhalabcompras.Models;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Minhalabcompras.Models
{
    public class LabComprasDbContext:DbContext
    {
        public DbSet<Produto> Produtos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connection =
            @"Server=(localdb)\mssqllocaldb;Database=DA2_2021_LABCOMPRAS;
            Trusted_Connection=True;";
            optionsBuilder.UseLazyLoadingProxies().UseSqlServer(connection);
        }
    }
}
