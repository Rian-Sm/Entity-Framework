using Alura.Loja.Testes.ConsoleApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alura.Loja.Testes.ConsoleApp.Context
{
    public class LojaContext : DbContext
    {
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            //base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=RIAN-MACEDO\\SQLEXPRESS;Initial Catalog=LojaDB;Integrated Security=True");
        }
    }
}
