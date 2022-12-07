using Alura.Loja.Testes.ConsoleApp.Context;
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
            //GravarUsandoAdoNet();
            //SaveUseEF();
            //GetProdutos();
            //UpdateProduto(2, "produto teste", "categoria teste", 100.05);
            //DeleteProduto(1);

            Console.ReadLine();

        }

        public static void SaveProduto()
        {
            Produto p = new Produto();
            p.Nome = "Harry Potter e a Ordem da Fênix";
            p.Categoria = "Livros";
            p.Preco = 19.89;

            using (var context = new LojaContext())
            {
                //repo.Adicionar(p);
                context.Produtos.Add(p);
                context.SaveChanges();
            }
        }

        public static List<Produto> GetProduto()
        {

            using (var context = new LojaContext())
            {
                 List<Produto> produtoList = context.Produtos.ToList();

                return produtoList;
            }
        }

        public static void UpdateProduto(int id, string nome, string categoria, double preco)
        {
            List<Produto> produtos = GetProduto();

            Produto prod = produtos.FirstOrDefault<Produto>(produto => produto.Id == id);

            if (prod == null) return;

            prod.Nome = nome;
            prod.Categoria = categoria;
            prod.Preco = preco;

            using (var context = new LojaContext())
            {
                context.Produtos.Update(prod);
                context.SaveChanges();
            }
        }

        public static void DeleteProduto(int id) {
            List<Produto> produtos = GetProduto();

            Produto prod = produtos.FirstOrDefault<Produto>(produto => produto.Id == id);

            using (var context = new LojaContext()) {
                context.Produtos.Remove(prod);
                context.SaveChanges();
            } 
        }


        private static void GravarUsandoAdoNet()
        {
            Produto p = new Produto();
            p.Nome = "Harry Potter e a Ordem da Fênix";
            p.Categoria = "Livros";
            p.Preco = 19.89;

            using (var repo = new ProdutoDAO())
            {
                repo.Adicionar(p);
            }
        }
    }
}
