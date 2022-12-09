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

            int quantidade = 2;

            prod.Nome = "abobora";
            prod.Categoria = "Vegetal";
            prod.PrecoUnitario = 7.99;
            prod.Unidade = "Kilos";

            Promocao promo = new Promocao();

            PromocaoProduto pp = new PromocaoProduto();
            pp.Produto = prod;

            promo.Descricao = "Promo teste";
            promo.DataInicio = DateTime.Now;
            promo.DataFim = DateTime.Now.AddDays(15);
            promo.Produtos.Add(pp);

            pedido.Produto = prod;
            pedido.Quantidade = quantidade;
            pedido.Valor = pedido.Produto.PrecoUnitario * pedido.Quantidade; 

            using (var entity = new LojaContext())
            {
                entity.Pedidos.Add(pedido);
                entity.SaveChanges();
            }

            Console.ReadLine();

        }

    }
}
