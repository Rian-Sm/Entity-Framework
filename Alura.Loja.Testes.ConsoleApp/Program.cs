using Alura.Loja.Testes.ConsoleApp.Context;
using Alura.Loja.Testes.ConsoleApp.DAO;
using Alura.Loja.Testes.ConsoleApp.Models;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alura.Loja.Testes.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            Produto prod = new Produto();
            Pedido pedido = new Pedido();

            prod.Nome = "abobora";
            prod.Categoria = "Vegetal";
            prod.PrecoUnitario = 7.99;
            prod.Unidade = "Kilos";

            pedido.Produto = prod;

            using (var entity = new ProdutoDAOEntity())
            {
                entity.Adicionar(prod);
            }

            Console.ReadLine();

        }

    }
}
